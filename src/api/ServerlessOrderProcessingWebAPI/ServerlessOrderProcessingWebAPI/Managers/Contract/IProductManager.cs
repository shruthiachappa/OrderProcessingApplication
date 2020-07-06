using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    /// <summary>
    /// GenerateSlip is common feature for all the three products and should be implented in all the classes which implementes this interface
    /// </summary>
    public interface IProductManager
    {
        bool GenerateSlip();
    }
}
