using CafeMenuProject.Models.Admin;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace CafeMenuProject.Business.Abstract
{
    public interface IUser
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Remove(User user);
        IResult Update(User user);
    }
}
