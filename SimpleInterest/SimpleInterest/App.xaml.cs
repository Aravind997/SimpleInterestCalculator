using SimpleInterest.Services;
using SimpleInterest.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleInterest
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SimpleInterestCalculator();
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
