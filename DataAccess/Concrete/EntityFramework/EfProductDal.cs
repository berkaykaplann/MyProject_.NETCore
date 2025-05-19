using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // EfEntityRepositoryBase: base bir sınıftır. kod tekrarı yapmamak için kullanılır. IProductDal'dan implementasyon yaparken, EfEntityRepositoryBase sınıfını kullanarak, Product sınıfı için gerekli olan veritabanı işlemlerini gerçekleştirebiliriz.
    public class EfProductDal : EfEntityRepositoryBase<Product, DatabaseContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                // Join işlemleri
                var result = from product in context.Products
                             join category in context.Categories
                             on product.CategoryId equals category.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = product.ProductId,
                                 ProductName = product.ProductName,
                                 CategoryName = category.CategoryName,
                                 UnitsInStock = product.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
