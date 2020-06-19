using SubscriptionPlan.XamarinUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SubscriptionPlan.XamarinUI
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            PlanList = new ObservableCollection<SubscriptionPlanModel>
            {
                new SubscriptionPlanModel
                {
                    Title = "Base",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Delegadis gente finis, bibendum egestas augue arcu ut est. Pra lá , depois divoltis porris, paradis. Copo furadis é disculpa de bebadis, arcu quam euismod magna. Si num tem leite então bota uma pinga aí cumpadi!

Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi. Não sou faixa preta cumpadi, sou preto inteiris, inteiris. Detraxit consequat et quo num tendi nada. Leite de capivaris, leite de mula manquis sem cabeça.

Praesent vel viverra nisi. Mauris aliquet nunc non turpis scelerisque, eget. Suco de cevadiss, é um leite divinis, qui tem lupuliz, matis, aguis e fermentis. Per aumento de cachacis, eu reclamis. Suco de cevadiss deixa as pessoas mais interessantis.",
                    Price = 10
                },
                new SubscriptionPlanModel
                {
                    Title = "Medium",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Delegadis gente finis, bibendum egestas augue arcu ut est. Pra lá , depois divoltis porris, paradis. Copo furadis é disculpa de bebadis, arcu quam euismod magna. Si num tem leite então bota uma pinga aí cumpadi!

Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi. Não sou faixa preta cumpadi, sou preto inteiris, inteiris. Detraxit consequat et quo num tendi nada. Leite de capivaris, leite de mula manquis sem cabeça.

Praesent vel viverra nisi. Mauris aliquet nunc non turpis scelerisque, eget. Suco de cevadiss, é um leite divinis, qui tem lupuliz, matis, aguis e fermentis. Per aumento de cachacis, eu reclamis. Suco de cevadiss deixa as pessoas mais interessantis.",
                    Price = 30
                },
                new SubscriptionPlanModel
                {
                    Title = "Ultimate",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Delegadis gente finis, bibendum egestas augue arcu ut est. Pra lá , depois divoltis porris, paradis. Copo furadis é disculpa de bebadis, arcu quam euismod magna. Si num tem leite então bota uma pinga aí cumpadi!

Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi. Não sou faixa preta cumpadi, sou preto inteiris, inteiris. Detraxit consequat et quo num tendi nada. Leite de capivaris, leite de mula manquis sem cabeça.

Praesent vel viverra nisi. Mauris aliquet nunc non turpis scelerisque, eget. Suco de cevadiss, é um leite divinis, qui tem lupuliz, matis, aguis e fermentis. Per aumento de cachacis, eu reclamis. Suco de cevadiss deixa as pessoas mais interessantis.",
                    Price = 90
                },
            };
        }

        public ObservableCollection<SubscriptionPlanModel> PlanList { get; set; }

        public SubscriptionPlanModel SelectedItem { get; set; }

    }
}
