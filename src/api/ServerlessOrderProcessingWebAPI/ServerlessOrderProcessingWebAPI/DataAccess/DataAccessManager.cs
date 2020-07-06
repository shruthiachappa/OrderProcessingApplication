using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.DataAccess
{
    public static class DataAccessManager
    {
        public static async Task<bool> SaveOrderToDBAsync(OrderTable order)
        {
            await DynamoDBService.Store(order,"OrderTable");
            return true;
        }
    }
}
