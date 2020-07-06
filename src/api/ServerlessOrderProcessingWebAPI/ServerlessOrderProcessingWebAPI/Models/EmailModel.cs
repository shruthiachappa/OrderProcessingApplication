using Amazon.SimpleEmail.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Models
{
    public class EmailModel
    {
        public string FromAddress { get; set; }

        public Destination ToDestination { get; set; } = new Destination();

        public string Subject { get; set; }

        public Message message { get; set; } = new Message();
    }
}
