using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        //void Add(List<Product> products);
        void Add();
        void Update(Order order);
        void Delete(Order order);
        List<Order> CheckOrderStatus();
        List<Order> CheckAllOrdersStatus();
    }
}
