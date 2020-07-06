using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerlessOrderProcessingWebAPI.Factory;
using ServerlessOrderProcessingWebAPI.Managers;
using ServerlessOrderProcessingWebAPI.Models;

namespace ServerlessOrderProcessingWebAPI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("postorder")]
        [HttpPost]
        public async Task<IActionResult> OrderProcess(OrderModel order)
        {
            ResponseModel response = new ResponseModel();
            ProductManagerFactory factory = new ProductManagerFactory();
            IProductManager productmanager = factory.GetProductManager(order.Product.ProductCode);
            response.SlipGeneration = productmanager.GenerateSlip();
            response.DuplicateSlipGeneration = productmanager.GenerateDuplicateSlip();
            response.ActivateMembership = productmanager.ActivateMembership();
            response.Upgrademembership = productmanager.UpgradeMembership();
            response.AddVideo = productmanager.AddVideo();

            return Ok(response);
        }
    }
}