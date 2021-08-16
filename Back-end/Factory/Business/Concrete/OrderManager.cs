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
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        private ICustomerService _customerService;
        //private IOrderItemService _orderItemService;
        public OrderManager(IOrderDal orderDal, ICustomerService customerService)
        {
            _orderDal = orderDal;
            _customerService = customerService;
            //_orderItemService = orderItemService;
        }

        public void Add()
        {
            Order order = new Order();
            order.CustomerId = _customerService.FindActiveCustomer().CustomerId;
            order.OrderDate = DateTime.Now;
            _orderDal.Add(order);
            //order.Deadline = DateTime.Now

            /*
            List<Order> orders = _orderDal.GetAll();
            int orderId = orders[orders.Count - 1].OrderId;

            foreach (var item in products)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = orderId;
                orderItem.ProductId = item.ProductId;
                _orderItemService.Add(orderItem);
            }
            */

        }

        public List<Order> CheckAllOrdersStatus()
        {
            return _orderDal.GetAll();
        }

        public List<Order> CheckOrderStatus()
        {
            Customer c = _customerService.FindActiveCustomer();
            return _orderDal.GetAll(o => o.CustomerId == c.CustomerId);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int id)
        {
            if (id > 0)
            {
                return _orderDal.Get(o => o.OrderId == id);
            }
            throw new Exception("id can not be less than 1");
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
