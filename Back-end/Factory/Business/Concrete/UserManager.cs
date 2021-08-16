using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            if (id > 0)
            {
                return _userDal.Get(u => u.UserId== id);
            }
            throw new Exception("id can not be less than 1");
        }

        public bool Login(string name, string password)
        {
            var query = _userDal.Get(u => u.Name == name && u.Password == password);
            if(query != null)
            {
                return true;
            }
            return false;
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
