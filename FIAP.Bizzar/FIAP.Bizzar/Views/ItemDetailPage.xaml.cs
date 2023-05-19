using FIAP.Bizzar.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FIAP.Bizzar.Views
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