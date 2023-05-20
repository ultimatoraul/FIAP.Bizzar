using FIAP.Bizzar.Services;
using FIAP.Bizzar.Views;
using Xamarin.Forms;

namespace FIAP.Bizzar
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataLoja>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new HomePage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
