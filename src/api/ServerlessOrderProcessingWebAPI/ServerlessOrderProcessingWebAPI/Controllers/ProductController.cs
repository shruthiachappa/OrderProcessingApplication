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
        public IActionResult PostOrder(OrderModel order)
        {
            ResponseModel response = new ResponseModel();
            ManagerFactory factory = new ManagerFactory();
            response = factory.GetProductManager(order);
            return Ok(response);
        }
    }
}