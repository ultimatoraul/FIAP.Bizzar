using FIAP.Bizzar.Data;
using FIAP.Bizzar.Models;
using FIAP.Bizzar.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FIAP.Bizzar.ViewModel
{
    internal class ProdutoViewModel : BaseViewModel
    {
		private readonly ProdutoRepository RepositoryProduto;

        public ProdutoViewModel()
        {
            RepositoryProduto = new ProdutoRepository();

            CarregarListaProduto();
        }

        private int idProduto;

		public int IdProduto
		{
			get { return idProduto; }
			set { idProduto = value; }
		}

		private string nomeProduto;

		public string NomeProduto
		{
			get { return nomeProduto; }
			set { nomeProduto = value; }
		}

		private string descricaoProduto;

		public string DescricaoProduto
        {
			get { return descricaoProduto; }
			set { descricaoProduto = value; }
		}

		private ObservableCollection<ProdutoModel> listaProduto;

		public ObservableCollection<ProdutoModel> ListaProduto
        {
			get { return listaProduto; }
			set { SetProperty(ref listaProduto, value); }
		}

		public Command GravarCommand
		{
			get
			{
				return new Command(() => {
                    ProdutoModel model = new ProdutoModel
                    {
						Descricao = this.DescricaoProduto,
						Nome = this.NomeProduto,
					};

                    RepositoryProduto.Insert(model);
                    CarregarListaProduto();
                });
			}
		}

        public void CarregarListaProduto()
        {
            ListaProduto = new ObservableCollection<ProdutoModel>(RepositoryProduto.GetList());
        }
	}
}
