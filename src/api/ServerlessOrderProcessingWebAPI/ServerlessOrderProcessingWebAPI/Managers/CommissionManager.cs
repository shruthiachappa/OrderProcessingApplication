using ServerlessOrderProcessingWebAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    /// <summary>
    /// GenerateCommission is common accross PhysicalProduct and Book so added in base class, can be extended in derived classes by using override property
    /// </summary>
    public class CommissionManager
    {
        public virtual bool GenerateCommission()
        {
            // Can be saved in dynamoDB / SQL
            // % of commission can be kept in DB or in Core business layer
            CommissionExtensions.GenerateGenericCommission();
            return true;
        }
    }
}
