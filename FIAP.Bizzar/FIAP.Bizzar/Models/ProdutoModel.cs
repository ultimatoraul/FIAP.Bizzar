using FIAP.Bizzar.Data;
using Xamarin.Forms;

namespace FIAP.Bizzar.Models
{
    public class ProdutoModel : BaseModel
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (nome != value)
                    nome = value;
            }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (descricao != value)
                    descricao = value;
            }
        }

        public Command DeletarCommand
        {
            get
            {
                return new Command(() => {
                    LojaModel model = new LojaModel
                    {
                        Id = this.Id,
                    };
                    var repository = new LojaRepository();
                    repository.Delete(model);
                });
            }
        }
    }
}