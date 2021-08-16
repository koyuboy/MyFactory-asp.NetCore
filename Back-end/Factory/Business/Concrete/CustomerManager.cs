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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }


        public void Delete([FromBody]Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public Customer FindActiveCustomer()
        {
            return _customerDal.Get(c => c.IsActive == true);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            if(id > 0)
            {
                return _customerDal.Get(c => c.CustomerId == id);
            }
            throw new Exception("id can not be less than 1");
            
        }
        
        public bool Login(string name, string password)
        {
            var query = _customerDal.Get(c => c.Name == name && c.Password == password);
            if (query != null)
            {
                Customer temp = FindActiveCustomer();
                if (temp!= null)
                {
                    temp.IsActive = false;
                    _customerDal.Update(temp);
                }

                query.IsActive = true;
                _customerDal.Update(query);
                return true;
            }
            return false;
        }

        public void Update([FromBody] Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
