using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    public class BookProductManager : CommissionManager, IProductManager
    {
        public bool GenerateSlip()
        {
            return true;
        }
    }
}
