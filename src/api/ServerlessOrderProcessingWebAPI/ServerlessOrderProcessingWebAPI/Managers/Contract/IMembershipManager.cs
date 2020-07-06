using ServerlessOrderProcessingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    /// <summary>
    /// SendEmail feature is common feature for Activate/Upgrade membership and should be implented in all the classes which implementes this interface
    /// </summary>
    public interface IMembershipManager
    {
        bool SendEmail(OrderModel order);
    }
}
