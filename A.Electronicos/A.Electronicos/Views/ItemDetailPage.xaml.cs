using A.Electronicos.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace A.Electronicos.Views
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