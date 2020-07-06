using ServerlessOrderProcessingWebAPI.Managers;
using ServerlessOrderProcessingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ServerlessOrderProcessingWebAPI.Core.Enums;

namespace ServerlessOrderProcessingWebAPI.Factory
{
    public class ManagerFactory
    {
        public ResponseModel GetProductManager(OrderModel order)
        {
            ResponseModel response = new ResponseModel();
            if (order.Product.ProductCode == (long)ProductTypeEnums.PhysicalProduct)
            {
                PhysicalProductManager managerObj = new PhysicalProductManager();
                managerObj.GenerateSlip();
                managerObj.GenerateCommission();
                response.Status = true;
            }
            else if (order.Product.ProductCode == (long)ProductTypeEnums.Book)
            {
                BookProductManager managerObj = new BookProductManager();
                managerObj.GenerateSlip();
                managerObj.GenerateCommission();
                response.Status = true;
            }
            else if (order.Product.ProductCode == (long)ProductTypeEnums.ActivateMembership)
            {
                MembershipManager managerObj = new MembershipManager();
                managerObj.SubmitMembership(true);
                managerObj.SendEmail(order);
                response.Status = true;
            }
            else if (order.Product.ProductCode == (long)ProductTypeEnums.UpgradeMembership)
            {
                MembershipManager managerObj = new MembershipManager();
                managerObj.SubmitMembership(true);
                managerObj.SendEmail(order);
                response.Status = true;
            }
            else if (order.Product.ProductCode == (long)ProductTypeEnums.Video)
            {
                VideoProductManager managerObj = new VideoProductManager();
                managerObj.GenerateSlip();
                response.Status = true;
            }
            return response;
        }
    }
}
