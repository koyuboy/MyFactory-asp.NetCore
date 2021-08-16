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
    public class OrderItemManager : IOrderItemService
    {
        private IOrderItemDal _orderItemDal;
        private IOrderService _orderService;

        public OrderItemManager(IOrderItemDal orderItemDal, IOrderService orderService)
        {
            _orderItemDal = orderItemDal;
            _orderService = orderService;
        }

        public void Add(Product product)
        {
            List<Order> orders = _orderService.GetAll();
            int orderId = orders[orders.Count - 1].OrderId;

            OrderItem orderItem = new OrderItem();
            orderItem.OrderId = orderId;
            orderItem.ProductId = product.ProductId;
            orderItem.Amount = 1;

            _orderItemDal.Add(orderItem);
        }

        public void Delete(OrderItem orderItem)
        {
            _orderItemDal.Delete(orderItem);
        }

        public List<OrderItem> GetAll()
        {
            return _orderItemDal.GetAll();
        }

        public OrderItem GetById(int id)
        {
            if (id > 0)
            {
                return _orderItemDal.Get(o => o.OrderItemId == id);
            }
            throw new Exception("id can not be less than 1");
        }

        public void Update(OrderItem orderItem)
        {
            _orderItemDal.Update(orderItem);
        }
    }
}
