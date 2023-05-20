using FIAP.Bizzar.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FIAP.Bizzar.Data
{
    public class LojaRepository : BaseRepository<LojaModel>
    {
        public LojaRepository() : base() { }

        public IList<LojaModel> GetList()
        {
            return Connection.Table<LojaModel>().ToList();
        }

        public LojaModel Get(Guid id)
        {
            return Connection.Table<LojaModel>().Where(i => i.Id == id).FirstOrDefault();
        }
    }
}
