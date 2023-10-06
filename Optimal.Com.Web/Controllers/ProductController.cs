using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Controller;
using Optimal.Com.Web.Framework.Data;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Controllers
{
    public class ProductController:BaseController
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;
        public ProductController(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductModel model)
        {
            Product entity = _mapper.Map<Product>(model);
            await _productRepository.AddAsync(entity);
            return Ok(entity);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _productRepository.Table.Where(s=>s.Id == id);
            return Ok(result);
        }
    }
}
