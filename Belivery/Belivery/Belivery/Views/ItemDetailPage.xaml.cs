using Belivery.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Belivery.Views
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