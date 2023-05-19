using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FIAP.Bizzar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VitrinePage : ContentPage
    {
        private int quantidade = 0;

        public VitrinePage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<string>(this, "adicionarItem", (s) =>
            {
                quantidade++;
                CarrinhoItens.Text = $"Itens: {quantidade}";
            });
        }

        private void ButtonProduct_Pressed(object sender, EventArgs e)
        {
            MessagingCenter.Send<string>("conteudoMensagem", "abrirTelaDetalhe");
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