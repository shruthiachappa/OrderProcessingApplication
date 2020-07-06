using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();

        [Required]
        public ProductModel Product { get; set; }
    }
}
