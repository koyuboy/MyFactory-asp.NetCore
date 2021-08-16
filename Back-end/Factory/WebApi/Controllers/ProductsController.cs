using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getbyid")]
        public Product GetById(int id)
        {
            return _productService.GetById(id);

        }

        [HttpGet("getall")]
        public List<Product> GetAll()
        {

            return _productService.GetAll();


        }

        [HttpPost("add")]
        public void Add(Product product)
        {
            _productService.Add(product);

        }

        [HttpPost("update")]
        public void Update(Product product)
        {
            _productService.Update(product);

        }

        [HttpPost("delete")]
        public void Delete(Product product)
        {
            _productService.Delete(product);

        }

        [HttpGet("getsalableproducts")] //müşterilerin sepetine ekleyebileceği ürünleri listeler, market alanı için
        public List<Product> GetSalableProducts()
        {
            return _productService.GetSalableProducts();

        }
    }
}
