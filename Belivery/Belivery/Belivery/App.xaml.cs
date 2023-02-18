using Belivery.Services;
using Belivery.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Belivery
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
           //Main1Page = new NavigationPage(new AboutPage());
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
