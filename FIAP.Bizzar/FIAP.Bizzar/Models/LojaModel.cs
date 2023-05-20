using FIAP.Bizzar.Data;
using Xamarin.Forms;

namespace FIAP.Bizzar.Models
{
    public class LojaModel : BaseModel
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

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                    email = value;
            }
        }

        private bool onLive;
        public bool OnLive
        {
            get { return onLive; }
            set
            {
                if (onLive != value)
                    onLive = value;
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
