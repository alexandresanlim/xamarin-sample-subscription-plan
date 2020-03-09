using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionPlan.XamarinUI.Models
{
    public class SubscriptionPlanModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PricePresentation { get { return Price.ToString("C"); } }
    }
}
