using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMVVMB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sueldo : ContentPage
    {
        public Sueldo()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.SueldoViewModel();

        }
    }
}