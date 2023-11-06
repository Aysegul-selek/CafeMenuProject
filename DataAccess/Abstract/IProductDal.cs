using CafeMenuProject.Models.Admin;
using Core.DataAccess;
using Entities.Admin;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    
    }
}
