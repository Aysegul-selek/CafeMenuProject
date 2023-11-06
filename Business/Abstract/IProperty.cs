using CafeMenuProject.Entities.Admin;
using CafeMenuProject.Models.Admin;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace CafeMenuProject.Business.Abstract
{
    public interface IProperty
    {
        IDataResult<List<Property>> GetAll();
        IResult Add(Property property);
        IResult Remove(Property property);
        IResult Update(Property property);
        IDataResult<Property> GetById(int id);
    }
}
