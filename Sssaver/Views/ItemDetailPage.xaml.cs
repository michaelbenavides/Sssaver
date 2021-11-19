using System.ComponentModel;
using Xamarin.Forms;
using Sssaver.ViewModels;

namespace Sssaver.Views
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
