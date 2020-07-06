using Amazon.DynamoDBv2.DataModel;
using ServerlessOrderProcessingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.DataAccess
{
    [DynamoDBTable("OrderTable")]
    public class OrderTable
    {
        [DynamoDBHashKey]
        public Guid OrderId { get; set; } = Guid.NewGuid();

        [DynamoDBProperty]
        public ProductModel Product { get; set; }

    }
}
