using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinBehaviorsEksempel.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        int counter = 0;

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            RainbowClick = new Command(() => MessagingCenter.Send(this, "RainBowClickMessage"));
        }
        
        public ICommand OpenWebCommand { get; }

        public ICommand RainbowClick { get; }
    }
}