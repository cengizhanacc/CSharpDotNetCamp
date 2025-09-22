using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//ProductTest();
CategoryTest();
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetByUnitPrice(30, 120))
    {
        Console.WriteLine(product.ProductName);
    }
}

static void CategoryTest()
{
    CategoryManager x = new CategoryManager(new EfCategoryDal());
    foreach (var y in x.GetAll())
    {
        Console.WriteLine(y.CategoryName);
    }
}