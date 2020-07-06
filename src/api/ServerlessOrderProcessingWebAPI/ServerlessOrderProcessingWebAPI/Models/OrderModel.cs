using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public ProductModel Product { get; set; }
    }
}
