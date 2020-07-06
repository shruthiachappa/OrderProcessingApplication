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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("postorder")]
        [HttpPost]
        public IActionResult PostOrder(OrderModel order)
        {
            ResponseModel response = new ResponseModel();
            ManagerFactory factory = new ManagerFactory();
            response = factory.OrderManager(order);
            return Ok(response);
        }
    }
}