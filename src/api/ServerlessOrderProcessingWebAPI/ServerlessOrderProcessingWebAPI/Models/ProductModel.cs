using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Models
{
    public class ProductModel
    {
        public Guid ProductId { get; set; }
        public long ProductCode { get; set; }
        public string ProductType { get; set; }
    }
}
