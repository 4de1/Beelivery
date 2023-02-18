using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Belivery.Views;
using Belivery.ViewModels;
using Belivery;

namespace Belivery.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            SaleCommand = new Command(OnMenuCommandExecuted);
        }
        public Command SaleCommand { get; }
        public ICommand OpenWebCommand { get; }
        private void OnMenuCommandExecuted(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new SalePage());
            
        }

    }
}