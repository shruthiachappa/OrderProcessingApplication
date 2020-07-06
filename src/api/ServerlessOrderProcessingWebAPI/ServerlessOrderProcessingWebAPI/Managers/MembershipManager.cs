using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessOrderProcessingWebAPI.Managers
{
    public class MembershipManager : IMembershipManager
    {
        public bool SendEmail()
        {
            return true;
        }

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
