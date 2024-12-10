using AutoMapper;
using Azure;
using microservice.product.Application.DTO;
using microservice.product.Application.Interface;
using microservice.product.domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace microservice.product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IUnitOfWork _unitOfWork, IMapper mapper) : Controller
    {
        private readonly IUnitOfWork unitOfWork = _unitOfWork;

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var response = await unitOfWork.Product.GetAll();
            if (response == null)
                return BadRequest();

            else
                return Ok(response);

        }

        [HttpGet("{id}")]
        public  async Task<IActionResult> GetProductById(int id)
        {
            var entity = await unitOfWork.Product.GetById(id);
            if (entity == null)
                return BadRequest();

            else
                return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductDTO entity)
        {
            var data = mapper.Map <ProductModel>(entity);
            await unitOfWork.Product.Add(data);
            await unitOfWork.Save();
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct([FromBody] ProductModel entity)
        {
             unitOfWork.Product.Update(entity);
            await unitOfWork.Save();
            return Ok(entity);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteProduct(int id)
        {
           await unitOfWork.Product.Delete(id);
           await unitOfWork.Save();
           return Ok();
        }   
    }
}
