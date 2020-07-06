using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.DataAccess
{
    public class DynamoDBService
    {
        #region DynamoDB Client
        public static AmazonDynamoDBClient DynamoDbClient = new AmazonDynamoDBClient(
          new AmazonDynamoDBConfig
          {
              ServiceURL = "https://dynamodb.amazonaws.com"
          });

        public static DynamoDBContext Context = new DynamoDBContext(DynamoDbClient);

        public async static Task Store<T>(T item, string tableName) where T : new()
        {
            await Context.SaveAsync(item, new DynamoDBOperationConfig()
            {
                OverrideTableName = tableName
            });
            // DbContext.Save(item);
        }
        #endregion
    }
}
