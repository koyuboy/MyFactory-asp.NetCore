using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderItemService
    {
        List<OrderItem> GetAll();
        OrderItem GetById(int id);
        void Add(Product product);
        void Update(OrderItem orderItem);
        void Delete(OrderItem orderItem);
    }
}
