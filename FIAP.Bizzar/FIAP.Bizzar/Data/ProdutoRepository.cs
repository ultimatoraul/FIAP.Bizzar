using FIAP.Bizzar.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FIAP.Bizzar.Data
{
    public class ProdutoRepository : BaseRepository<ProdutoModel>
    {
        public ProdutoRepository() : base() { }

        public IList<ProdutoModel> GetList()
        {
            return Connection.Table<ProdutoModel>().ToList();
        }

        public ProdutoModel Get(Guid id)
        {
            return Connection.Table<ProdutoModel>().Where(i => i.Id == id).FirstOrDefault();
        }
    }
}
