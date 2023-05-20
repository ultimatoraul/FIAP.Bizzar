using FIAP.Bizzar.Models;
using FIAP.Bizzar.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FIAP.Bizzar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(ProdutoModel itemModel)
        {
            InitializeComponent();
            var vm = new ItemDetailViewModel(itemModel);
            BindingContext = vm;
        }
    }
}