using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Models
{
    public class ResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public bool SlipGeneration { get; set; }
        public bool DuplicateSlipGeneration { get; set; }
        public bool ActivateMembership { get; set; }
        public bool Upgrademembership { get; set; }
        public bool CommissionGeneration { get; set; }
        public bool AddVideo { get; set; }
    }
}
