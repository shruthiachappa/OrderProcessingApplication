using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    public class PhysicalProductManager : IProductManager
    {
        public bool ActivateMembership()
        {
            return true;
        }

        public bool GenerateCommission()
        {
            return true;
        }

        public bool GenerateDuplicateSlip()
        {
            return true;
        }

        public bool GenerateSlip()
        {
            return true;
        }

        public bool UpdateVideo()
        {
            return true;
        }

        public bool Upgrademembership()
        {
            return true;
        }
    }
}
