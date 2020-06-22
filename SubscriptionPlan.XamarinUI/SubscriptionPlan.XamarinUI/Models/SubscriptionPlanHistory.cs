using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SubscriptionPlan.XamarinUI.Models
{
    public class SubscriptionPlanHistory
    {
        public SubscriptionPlan SubscriptionPlan { get; set; }

        public DateTime Date { get; set; }

        public string DatePresentation => Date.ToString("dd MMMM yyyy");

        public static ObservableCollection<SubscriptionPlanHistory> Get()
        {
            return new ObservableCollection<SubscriptionPlanHistory>
            {
                new SubscriptionPlanHistory
                {
                    SubscriptionPlan = SubscriptionPlan.Get(),
                    Date = DateTime.Now.AddDays(-30)
                },
                new SubscriptionPlanHistory
                {
                    SubscriptionPlan = SubscriptionPlan.Get(),
                    Date = DateTime.Now.AddDays(-60)
                },
                new SubscriptionPlanHistory
                {
                    SubscriptionPlan = SubscriptionPlan.Get(),
                    Date = DateTime.Now.AddDays(-90)
                },
                new SubscriptionPlanHistory
                {
                    SubscriptionPlan = SubscriptionPlan.Get(),
                    Date = DateTime.Now.AddDays(-120)
                },
                new SubscriptionPlanHistory
                {
                    SubscriptionPlan = SubscriptionPlan.Get(),
                    Date = DateTime.Now.AddDays(-150)
                },
            };
        }
    }
}
