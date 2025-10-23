using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager x = new ProductManager(new EfProductDal());

    var result = x.GetProductDetails();
    if (result.Success == true)
    {
        foreach (var y in result.Data)
        {
            Console.WriteLine(y.ProductName + "/" + y.CategoryName);
        }

    }
    else
    {
        Console.WriteLine(result.Message);
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

