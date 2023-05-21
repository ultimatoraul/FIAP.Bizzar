using FIAP.Bizzar.Data;
using FIAP.Bizzar.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FIAP.Bizzar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            if (new LojaRepository().GetList().Count == 0)
                new MockDataLoja().SaveMock();

            if (new ProdutoRepository().GetList().Count == 0)
                new MockDataProduto().SaveMock();

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}