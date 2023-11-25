using DemoMVVMB.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DemoMVVMB.Views
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