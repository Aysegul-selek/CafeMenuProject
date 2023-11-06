using CafeMenuProject.Models.Admin;
using Core.Utilities.Results;
using Entities.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategory
    {
        IDataResult<List<Category>> GetAll();
        IResult Add(Category category);
        IResult Remove(Category category);
        IResult Update(Category category);
        IDataResult<Category> GetById(int id);
    }
}
