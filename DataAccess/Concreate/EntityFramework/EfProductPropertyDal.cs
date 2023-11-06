using CafeMenuProject.Entities.Admin;
using CafeMenuProject.Models.Admin;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductPropertyDal:EfEntityRepoSitoryBase<ProductProperty, CafeMenuContext>,IProductPropertyDal
    {
      
    }
}
