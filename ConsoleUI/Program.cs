

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

// ProductTest();
// CategoryTest();
//ProductDetailTest();
ProductSuccessTest();

static void ProductSuccessTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetails();
    if (result.isSuccess==true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}
//static void ProductDetailTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());
//    foreach (var product in productManager.GetProductDetails())
//    {
//        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
//    }
//}


//static void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());

//    foreach (var product in productManager.GetAllByCategoryId(2))
//    {
//        Console.WriteLine(product.ProductName);
//    }
//}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}