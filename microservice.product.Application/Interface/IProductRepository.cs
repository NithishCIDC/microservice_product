﻿using microservice.product.domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microservice.product.Application.Interface
{
    public  interface IProductRepository : IGenericRepository<ProductModel>
    {
        Task<List<ProductModel>> GetProductByCID(int id);
        Task DeleteProductWithCustomer(int id);
    }
}
