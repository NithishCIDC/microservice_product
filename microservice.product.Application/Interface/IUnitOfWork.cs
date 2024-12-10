using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microservice.product.Application.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository Product { get; }

        Task Save();
    }
}
