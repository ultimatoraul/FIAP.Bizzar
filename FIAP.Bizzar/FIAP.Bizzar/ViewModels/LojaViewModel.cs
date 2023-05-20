using FIAP.Bizzar.Data;
using FIAP.Bizzar.Models;
using FIAP.Bizzar.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FIAP.Bizzar.ViewModel
{
    internal class LojaViewModel : BaseViewModel
    {
		private readonly LojaRepository RepositoryLoja;

        public LojaViewModel()
        {
            RepositoryLoja = new LojaRepository();

            CarregarListaLoja();
        }

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
	}
}
