using CafeMenuProject.Models.Admin;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepoSitoryBase<User, CafeMenuContext>, IUserDal
    {
       
    }
}
