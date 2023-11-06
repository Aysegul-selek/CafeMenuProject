using Business.Constants;
using CafeMenuProject.Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Admin;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ProductManager : IProduct
    {
        IProductDal _productDal;

        public ProductManager()
        {
        }

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
       
        public IResult Add(Product product)
        {
           
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);


        }
     
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll().ToList());
        }

        public IDataResult<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Product product)
        {
            if (product.ProductID == null)
            { return new ErrorResult(Messages.Error); }
            _productDal.Delete(product);
            return new SuccessResult(Messages.Success);
        }

        public IResult Update(Product product)
        {
           
                _productDal.Update(product);
               return new SuccessResult(Messages.ProductAdded);
        }

    }
}
