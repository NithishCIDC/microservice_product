using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microservice.product.Application.DTO
{
    public class ProductDTO
    {
        public string? productName { get; set; }

        public string? productCompany { get; set; }

        public decimal? productPrice { get; set; }

        public int productDiscount { get; set; }
    }
}
