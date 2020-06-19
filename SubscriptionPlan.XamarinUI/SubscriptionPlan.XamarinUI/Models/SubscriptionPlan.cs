using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionPlan.XamarinUI.Models
{
    public class SubscriptionPlan
    {
        public Plan Plan { get; set; }

        public CreditCart CreditCart { get; set; }

        public static SubscriptionPlan Get()
        {
            return new SubscriptionPlan
            {
                CreditCart = new CreditCart
                {
                    Number = "**** **** **** 9999",
                    Name = "Hans",
                    Surname = "Hoppe"
                }
            };
        }
    }
}
