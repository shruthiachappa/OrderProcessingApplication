using ServerlessOrderProcessingWebAPI.Managers;
using ServerlessOrderProcessingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ServerlessOrderProcessingWebAPI.Core.Enums;

namespace ServerlessOrderProcessingWebAPI.Factory
{
    public class ProductManagerFactory
    {
        public IProductManager GetProductManager(long productType)
        {
            IProductManager returnValue = null;
            if (productType == (long)ProductTypeEnums.PhysicalProduct)
            {
                returnValue = new PhysicalProductManager();
            }
            else if (productType == (long)ProductTypeEnums.Book)
            {
                returnValue = new PhysicalProductManager();
            }
            else if (productType == (long)ProductTypeEnums.ActivateMembership)
            {
                returnValue = new PhysicalProductManager();
            }
            else if (productType == (long)ProductTypeEnums.UpgradeMembership)
            {
                returnValue = new PhysicalProductManager();
            }
            else if (productType == (long)ProductTypeEnums.Video)
            {
                returnValue = new PhysicalProductManager();
            }
            return returnValue;
        }
    }
}
