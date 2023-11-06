using Business.Constants;
using CafeMenuProject.Business.Abstract;
using CafeMenuProject.Entities.Admin;
using CafeMenuProject.Models.Admin;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace CafeMenuProject.Business.Concrete
{
    public class PropertyManager : IProperty
    {
        IPropertyDal _propertyDal;

        public PropertyManager()
        {
        }

        public PropertyManager(IPropertyDal property)
        {
            _propertyDal = property;
        }

      public  IResult Add(Property property)
        {
            _propertyDal.Add(property);
            return new SuccessResult(Messages.Success);
        }


        public  IDataResult<List<Property>> GetAll()
        { 
            return new SuccessDataResult<List<Property>>(_propertyDal.GetAll().ToList());
        }

        public IDataResult<Property> GetById(int id)
        {
            return new SuccessDataResult<Property>(_propertyDal.Get(b => b.PropertyID == id));
        }

        public IResult Remove(Property property)
        {
            _propertyDal.Delete(property);
            return new SuccessResult(Messages.Success);
        }

      public  IResult Update(Property property)
        {
            _propertyDal.Update(property);
            return new SuccessResult(Messages.Success);
        }
    }
}
