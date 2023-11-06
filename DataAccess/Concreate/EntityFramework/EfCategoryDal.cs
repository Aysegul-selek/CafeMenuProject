using CafeMenuProject.Models.Admin;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Admin;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepoSitoryBase<Category, CafeMenuContext>, ICategoryDal
    {
       
    }
}
