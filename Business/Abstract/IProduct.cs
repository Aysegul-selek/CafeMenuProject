using Core.Utilities.Results;
using Entities.Admin;
using System.Collections.Generic;

namespace CafeMenuProject.Business.Abstract
{
    public interface IProduct
    {
        IDataResult<List<Product>> GetAll();
        IResult Add(Product product);
        IResult Remove(Product product);
        IResult Update(Product product);
        IDataResult<Product> GetById(int id);
    }
}
