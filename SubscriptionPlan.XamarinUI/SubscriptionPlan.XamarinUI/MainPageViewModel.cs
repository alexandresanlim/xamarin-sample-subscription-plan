using SubscriptionPlan.XamarinUI.Interfaces;
using SubscriptionPlan.XamarinUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SubscriptionPlan.XamarinUI
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            CurrentPlan = Plan.GetPlans().FirstOrDefault();
            CurrentSubscriptionPlan = Models.SubscriptionPlan.Get();
            CurrentSubscriptionPlanHistory = new ObservableCollection<SubscriptionPlanHistory>(SubscriptionPlanHistory.Get().OrderByDescending(x => x.Date));
        }

        public Plan CurrentPlan { get; set; }

        public Models.SubscriptionPlan CurrentSubscriptionPlan { get; set; }

        public ObservableCollection<SubscriptionPlanHistory> CurrentSubscriptionPlanHistory { get; set; }

        public Command NavigateToUpgradePlanCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new ChoosePlan());
        });
    }
}
