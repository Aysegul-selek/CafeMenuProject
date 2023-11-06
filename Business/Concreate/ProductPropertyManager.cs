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
    public class ProductPropertyManager : IProductProperty
    {
        IProductPropertyDal _productPropertyDal;

        public ProductPropertyManager(IProductPropertyDal productPropertyDal)
        {
            _productPropertyDal = productPropertyDal;
        }

        public IResult Add(ProductProperty productProperty)
        {
            _productPropertyDal.Add(productProperty);
            return new SuccessResult(Messages.Success);
        }

       public IDataResult<List<ProductProperty>> GetAll()
        {
            return new SuccessDataResult<List<ProductProperty>>(_productPropertyDal.GetAll().ToList());
        }

        public IDataResult<ProductProperty> GetById(int id)
        {       
                return new SuccessDataResult<ProductProperty>(_productPropertyDal.Get(b => b.ProductPropertyId == id));
            
        }

        public IResult Remove(ProductProperty productProperty)
        {
            if (productProperty.ProductPropertyId== null)
            { return new ErrorResult(Messages.Error); }
            _productPropertyDal.Delete(productProperty);
            return new SuccessResult(Messages.Success);
        }

       public IResult Update(ProductProperty productProperty)
        {
            _productPropertyDal.Update(productProperty);
            return new SuccessResult(Messages.Success);
        }
    }
}
