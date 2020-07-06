using Amazon.CloudWatchLogs.Model;
using ServerlessOrderProcessingWebAPI.Core;
using ServerlessOrderProcessingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    public class MembershipManager : IMembershipManager
    {
        /// <summary>
        /// Send email extension is called based on email model
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool SendEmail(OrderModel order)
        {
            EmailModel model = new EmailModel()
            {
                FromAddress = "FROMADDRESS@TEST.com", // can be further configurable in resource file or in settings
                Subject = "Activating/upgrading membership"
            };
            SendEmailExtension.SendEmail(model);
            return true;
        }

        /// <summary>
        /// Based on type of membership. activate/upgrade is happening
        /// </summary>
        /// <param name="isNew"></param>
        /// <returns></returns>
        public bool SubmitMembership(bool isNew)
        {
            bool result = false;
            if (isNew)
                result = ActivateMembership();
            else
                result = UpgradeMembership();
            return result;
        }

        #region private methods
        private bool ActivateMembership()
        {
            return true;
        }

        private bool UpgradeMembership()
        {
            return false;
        }
        #endregion
    }
}
