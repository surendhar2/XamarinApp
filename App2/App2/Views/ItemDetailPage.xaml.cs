using System.ComponentModel;
using Xamarin.Forms;
using App2.ViewModels;

namespace App2.Views
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