using microservice.product.Application.Interface;
using microservice.product.domain.Model;
using microservice.product.Infrastructure.Data;

namespace microservice.product.Infrastructure.Repository
{
    public class ProductRepository(ProductDbContext dbcontext) : GenericRepositoy<ProductModel>(dbcontext) , IProductRepository
    {

    }
    
}
