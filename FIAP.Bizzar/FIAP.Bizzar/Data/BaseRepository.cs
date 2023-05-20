using FIAP.Bizzar.Config;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

namespace FIAP.Bizzar.Data
{
    public abstract class BaseRepository<T> : IDisposable
    {
        public SQLiteConnection Connection { get; set; }

        public BaseRepository()
        {
            var dbPathConfig = DependencyService.Get<IDbPathConfig>();
            var caminho = Path.Combine(dbPathConfig.Path, "fiap.db");
            Connection = new SQLiteConnection(caminho);
            Connection.CreateTable<T>();
        }

        public void Dispose()
        {
            Connection?.Dispose();
            throw new NotImplementedException();
        }

        public void Insert(T _model)
        {
            Connection.Insert(_model);
        }

        public void Update(T _model)
        {
            Connection.Update(_model);
        }

        public void Delete(T _model)
        {
            Connection.Delete(_model);
        }

        public void DropTable()
        {
            Connection.DropTable<T>();
        }
    }
}
