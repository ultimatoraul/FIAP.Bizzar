using FIAP.Bizzar.Data;
using FIAP.Bizzar.Models;
using FIAP.Bizzar.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Bizzar.ViewModel
{
    internal class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            RepositoryProduto = new ProdutoRepository();

            CarregarListaProduto();

            RepositoryLoja = new LojaRepository();

            CarregarListaLoja();
        }
        
        private string campoBusca;

        public string CampoBusca
        {
            get { return campoBusca; }
            set { campoBusca = value; }
        }

        #region Loja
        private readonly LojaRepository RepositoryLoja;

        private int idLoja;

        public int IdLoja
        {
            get { return idLoja; }
            set { idLoja = value; }
        }

        private string nomeLoja;

        public string NomeLoja
        {
            get { return nomeLoja; }
            set { nomeLoja = value; }
        }

        private string emailLoja;

        public string EmailLoja
        {
            get { return emailLoja; }
            set { emailLoja = value; }
        }

        private ObservableCollection<LojaModel> listaLoja;

        public ObservableCollection<LojaModel> ListaLoja
        {
            get { return listaLoja; }
            set { SetProperty(ref listaLoja, value); }
        }

        public Command LojaGravarCommand
        {
            get
            {
                return new Command(() => {
                    LojaModel model = new LojaModel
                    {
                        Email = this.EmailLoja,
                        Nome = this.NomeLoja,
                    };

                    RepositoryLoja.Insert(model);
                    CarregarListaLoja();
                });
            }
        }

        public void CarregarListaLoja()
        {
            ListaLoja = new ObservableCollection<LojaModel>(RepositoryLoja.GetList());
        }
        #endregion

        #region Produto
        private readonly ProdutoRepository RepositoryProduto;

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
        #endregion
    }
}
