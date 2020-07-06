using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Models
{
    public class ProductModel
    {
        [MaxLength(20)]
        public Guid ProductId { get; set; } = Guid.NewGuid();

        [Required]
        public long ProductCode { get; set; }

        [MaxLength(50)]
        public string ProductType { get; set; }
    }
}
