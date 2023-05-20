using FIAP.Bizzar.Models;
using FIAP.Bizzar.ViewModels;
using Xamarin.Forms;

namespace FIAP.Bizzar.Views
{
    public partial class NewItemPage : ContentPage
    {
        public ProdutoModel Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}