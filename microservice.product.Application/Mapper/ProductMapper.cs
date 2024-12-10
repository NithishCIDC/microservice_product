using AutoMapper;
using microservice.product.Application.DTO;
using microservice.product.domain.Model;

namespace microservice.product.Application.Mapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductDTO, ProductModel>();
        }
    }
}
