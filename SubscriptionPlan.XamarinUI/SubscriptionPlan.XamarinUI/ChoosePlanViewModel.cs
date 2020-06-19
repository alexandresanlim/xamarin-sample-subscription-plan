using SubscriptionPlan.XamarinUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SubscriptionPlan.XamarinUI
{
    public class ChoosePlanViewModel
    {
        public ChoosePlanViewModel()
        {
            PlanList = Plan.GetPlans();
        }

        public ObservableCollection<Plan> PlanList { get; set; }

        public Plan SelectedItem { get; set; }
    }
}
