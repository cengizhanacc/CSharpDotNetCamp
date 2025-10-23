using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
       IDataResult<List<Product>> Getall();

        IDataResult<List<Product>> GetAllByCategoryId(int id);

        IDataResult<Product> GetById(int productId);

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product x);
    }
}
