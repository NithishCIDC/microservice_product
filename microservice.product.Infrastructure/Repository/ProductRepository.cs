using microservice.product.Application.Interface;
using microservice.product.domain.Model;
using microservice.product.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace microservice.product.Infrastructure.Repository
{
    public class ProductRepository(ProductDbContext dbcontext) : GenericRepositoy<ProductModel>(dbcontext), IProductRepository
    {
        public async Task<List<ProductModel>> GetProductByCID(int id)
        {
            var product = await dbcontext.Product.Where(product => product.CustomerId == id).ToListAsync();
            return product;
        }

        public async Task DeleteProductWithCustomer(int id)
        {
            var Product = await dbcontext.Product.Where(product => product.CustomerId == id).ToListAsync();
            dbcontext.RemoveRange(Product);
            await dbcontext.SaveChangesAsync();
        }

    }

}
