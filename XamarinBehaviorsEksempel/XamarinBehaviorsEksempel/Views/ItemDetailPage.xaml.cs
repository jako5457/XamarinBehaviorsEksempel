using System.ComponentModel;
using Xamarin.Forms;
using XamarinBehaviorsEksempel.ViewModels;

namespace XamarinBehaviorsEksempel.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}