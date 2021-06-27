using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static FirstUWPApp.App;

namespace FirstUWPApp.domainclasses
{
    public class SubscribedCustomer : Customer
    {
        private SubscriptionTier subscriptionTier;

        public SubscribedCustomer(string name, string cellphoneNumber, SubscriptionTier subscriptionTier)
            : base(name,cellphoneNumber)
        {
            this.subscriptionTier = subscriptionTier;
        }

        public SubscriptionTier SubscriptionTier { get => subscriptionTier; set => subscriptionTier = value; }
    }
}
