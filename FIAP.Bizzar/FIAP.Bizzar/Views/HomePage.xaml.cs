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
            InitializeComponent();

            //new MockDataLoja().SaveMock();
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