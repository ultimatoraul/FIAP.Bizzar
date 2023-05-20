using FIAP.Bizzar.Config;
using Xamarin.Forms;

[assembly: Dependency(typeof(FIAP.Bizzar.iOS.Config.DbPathConfig))]
namespace FIAP.Bizzar.iOS.Config
{
    public class DbPathConfig : IDbPathConfig
    {
        private string path;

        public string Path
        {
            get
            {
                if (string.IsNullOrEmpty(path))
                {
                    path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    path = System.IO.Path.Combine(path, "..", "Library");
                }
                return path;
            }
        }
    }
}
