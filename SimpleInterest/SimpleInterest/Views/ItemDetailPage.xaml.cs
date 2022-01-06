using SimpleInterest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimpleInterest.Views
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