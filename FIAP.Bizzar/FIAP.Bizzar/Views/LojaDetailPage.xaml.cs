using FIAP.Bizzar.Models;
using FIAP.Bizzar.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FIAP.Bizzar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LojaDetailPage : ContentPage
    {
        public LojaDetailPage(LojaModel itemModel)
        {
            InitializeComponent();
            var vm = new LojaViewModel(itemModel);
            BindingContext = vm;
        }
    }
}