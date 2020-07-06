using ServerlessOrderProcessingWebAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    /// <summary>
    /// Physical     product needs generate slip(from interface) and GenerateCommission from Commission(base class)- multiple inheritance is implented
    /// </summary>
    public class PhysicalProductManager : CommissionManager, IProductManager
    {
        public bool GenerateSlip()
        {
            // Can be saved in dynamoDB / SQL
            //implement logic for Slip
            SlipExtensions.GenerateGenericSlip();
            return true;
        }

        /// <summary>
        /// This method is overridden and this will be called dynamically since we added this method, else base class method will be called
        /// </summary>
        /// <returns></returns>
        public override bool GenerateCommission()
        {
            // Can be saved in dynamoDB / SQL
            //implement logic for commission
            return true;
        }
    }
}
