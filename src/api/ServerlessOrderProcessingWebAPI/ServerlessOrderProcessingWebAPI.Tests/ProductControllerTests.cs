using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerlessOrderProcessingWebAPI.Controllers;
using ServerlessOrderProcessingWebAPI.Models;
using Xunit;
using static ServerlessOrderProcessingWebAPI.Core.Enums;

namespace ServerlessOrderProcessingWebAPI.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void PostOrder_PhysicalProduct_ReturnSuccess()
        {
            OrderModel order = new OrderModel()
            {
                OrderId = new Guid("65e9689c-97e9-40e4-8a27-624a02daa579"),
                Product = new ProductModel()
                {
                    ProductCode = (long)ProductTypeEnums.PhysicalProduct,
                    ProductId = new Guid("65a1689c-97e9-40e4-8a27-624a02daa579"),
                    ProductType = ProductTypeEnums.PhysicalProduct.ToString()
                }

            };
            var controller = new ProductController();

            IActionResult result = controller.PostOrder(order);
            var okResult = result as OkObjectResult;

            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public void PostOrder_Book_ReturnSuccess()
        {
            OrderModel order = new OrderModel()
            {
                OrderId = new Guid("65e9689c-97e9-40e4-8a27-624a02daa579"),
                Product = new ProductModel()
                {
                    ProductCode = (long)ProductTypeEnums.Book,
                    ProductId = new Guid("65a1689c-97e9-40e4-8a27-624a02daa579"),
                    ProductType = ProductTypeEnums.Book.ToString()
                }

            };
            var controller = new ProductController();

            IActionResult result = controller.PostOrder(order);
            var okResult = result as OkObjectResult;

            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public void PostOrder_Video_ReturnSuccess()
        {
            OrderModel order = new OrderModel()
            {
                OrderId = new Guid("65e9689c-97e9-40e4-8a27-624a02daa579"),
                Product = new ProductModel()
                {
                    ProductCode = (long)ProductTypeEnums.Video,
                    ProductId = new Guid("65a1689c-97e9-40e4-8a27-624a02daa579"),
                    ProductType = ProductTypeEnums.Video.ToString()
                }

            };
            var controller = new ProductController();

            IActionResult result = controller.PostOrder(order);
            var okResult = result as OkObjectResult;

            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public void PostOrder_ActivateMembership_ReturnSuccess()
        {
            OrderModel order = new OrderModel()
            {
                OrderId = new Guid("65e9689c-97e9-40e4-8a27-624a02daa579"),
                Product = new ProductModel()
                {
                    ProductCode = (long)ProductTypeEnums.ActivateMembership,
                    ProductId = new Guid("65a1689c-97e9-40e4-8a27-624a02daa579"),
                    ProductType = ProductTypeEnums.ActivateMembership.ToString()
                }

            };
            var controller = new ProductController();

            IActionResult result = controller.PostOrder(order);
            var okResult = result as OkObjectResult;

            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public void PostOrder_UpgradeMembership_ReturnSuccess()
        {
            OrderModel order = new OrderModel()
            {
                OrderId = new Guid("65e9689c-97e9-40e4-8a27-624a02daa579"),
                Product = new ProductModel()
                {
                    ProductCode = (long)ProductTypeEnums.UpgradeMembership,
                    ProductId = new Guid("65a1689c-97e9-40e4-8a27-624a02daa579"),
                    ProductType = ProductTypeEnums.UpgradeMembership.ToString()
                }

            };
            var controller = new ProductController();

            IActionResult result = controller.PostOrder(order);
            var okResult = result as OkObjectResult;

            Assert.Equal(200, okResult.StatusCode);
        }
    }
}
