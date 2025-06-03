

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

// ProductTest();
// CategoryTest();
// ProductDetailTest();
// ProductSuccessTest();
// CustomerAddedTest();
//CustomerListedTest();

static void CustomerListedTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    var result = customerManager.GetAll();
    foreach (var customer in result.Data)
    {
        Console.WriteLine(customer.CustomerId + "/" + customer.CompanyName + "/" + customer.ContactName + "/" + customer.City);
    }
}
    static void CustomerAddedTest()
{
    CustomerManager customerManager= new CustomerManager(new EfCustomerDal());
    Console.WriteLine("Adınızı Girin:");
    string name = Console.ReadLine();
    Console.WriteLine("Şirket Girin:");
    string companyName = Console.ReadLine();
    Console.WriteLine("Şehir Girin:");
    string city = Console.ReadLine();
    customerManager.Add(new Customer
    {
        CustomerId = "1",
        CompanyName = companyName,
        ContactName = name,
        City = city
    });
}


//static void ProductSuccessTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());

//    var result = productManager.GetProductDetails();
//    if (result.isSuccess==true)
//    {
//        foreach (var product in result.Data)
//        {
//            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
//        }
//    }
//    else
//    {
//        Console.WriteLine(result.Message);
//    }

//}
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

    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}