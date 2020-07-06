using ServerlessOrderProcessingWebAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    /// <summary>
    /// Video product needs only generate slip(from interface) so implemented that
    /// </summary>
    public class VideoProductManager : IProductManager
    {
        /// <summary>
        /// If its video, thats added to slip as well
        /// </summary>
        /// <returns></returns>
        public bool GenerateSlip()
        {
            //Can be saved in dynamoDB / SQL
            //implement logic for commission
            SlipExtensions.GenerateGenericSlip();
            return true;
        }
    }
}
