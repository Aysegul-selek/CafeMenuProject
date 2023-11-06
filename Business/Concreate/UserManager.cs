using Business.Constants;
using CafeMenuProject.Business.Abstract;
using CafeMenuProject.Models.Admin;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUser
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IResult Remove(User user)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
