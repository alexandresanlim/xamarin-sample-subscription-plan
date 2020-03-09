using SubscriptionPlan.XamarinUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace SubscriptionPlan.XamarinUI
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            PlanList = new ObservableCollection<SubscriptionPlanModel>
            {
                new SubscriptionPlanModel
                {
                    Title = "Base",
                    Description = "Description Plan",
                    Price = 10
                },
                new SubscriptionPlanModel
                {
                    Title = "Medium",
                    Description = "Description Plan",
                    Price = 30
                },
                new SubscriptionPlanModel
                {
                    Title = "Ultimate",
                    Description = "Description Plan",
                    Price = 100
                },
                new SubscriptionPlanModel
                {
                    Title = "Ultimate",
                    Description = "Description Plan",
                    Price = 100
                }
            };
        }

        public ObservableCollection<SubscriptionPlanModel> PlanList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
