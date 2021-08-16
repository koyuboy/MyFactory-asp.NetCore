using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            if (id > 0)
            {
                return _productDal.Get(p => p.ProductId== id);
            }
            throw new Exception("id can not be less than 1");
        }

        public List<Product> GetSalableProducts()
        {
            return _productDal.GetAll(p => p.IsSalable == true);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
