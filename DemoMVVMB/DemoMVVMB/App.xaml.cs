using DemoMVVMB.Services;
using DemoMVVMB.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMVVMB
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new DemoMVVMB.Views.Sueldo();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
