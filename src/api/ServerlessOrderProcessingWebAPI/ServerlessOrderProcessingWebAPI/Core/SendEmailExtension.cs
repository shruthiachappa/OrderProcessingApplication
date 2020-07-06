using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using ServerlessOrderProcessingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Core
{
    public static class SendEmailExtension
    {
        public static void SendEmail(EmailModel model)
        {
            using (var client = new AmazonSimpleEmailServiceClient("Accesskey", "SecretKey"))
            {
                var emailRequest = new SendEmailRequest()
                {
                    Source = model.FromAddress,
                    Destination = model.ToDestination,
                    Message = model.message
                };

                emailRequest.Destination.ToAddresses.Add("TOADDRESS@TEST.COM");
                emailRequest.Message.Subject = new Content(model.Subject);
                emailRequest.Message.Body = new Body(new Content(""));
                client.SendEmail(emailRequest);
            }
        }
    }
}
