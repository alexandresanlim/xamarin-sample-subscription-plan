using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionPlan.XamarinUI.Models
{
    public class CreditCart
    {
        public string Number { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName => Name + " " + Surname;
    }
}
