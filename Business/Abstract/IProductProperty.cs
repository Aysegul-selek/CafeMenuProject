using CafeMenuProject.Entities.Admin;
using CafeMenuProject.Models.Admin;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace CafeMenuProject.Business.Abstract
{
    public interface IProductProperty
    {
        IDataResult<List<ProductProperty>> GetAll();
        IResult Add(ProductProperty productProperty);
        IResult Remove(ProductProperty productProperty);
        IResult Update(ProductProperty productProperty);
        IDataResult<ProductProperty> GetById(int id);
    }
}
