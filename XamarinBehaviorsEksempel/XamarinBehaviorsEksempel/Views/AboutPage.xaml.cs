using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBehaviorsEksempel.ViewModels;

namespace XamarinBehaviorsEksempel.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<AboutViewModel>(this, "RainBowClickMessage", model => DisplayAlert("Info", "Color of button changed!", "Ok"));

        }
    }
}