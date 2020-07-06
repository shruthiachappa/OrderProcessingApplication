using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Core
{
    public class Enums
    {
        public enum ProductTypeEnums
        {
            PhysicalProduct = 001,
            Book = 002,
            ActivateMembership = 003,
            UpgradeMembership = 004,
            Video = 005
        }
    }
}
