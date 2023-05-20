using FIAP.Bizzar.Data;
using FIAP.Bizzar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Bizzar.Services
{
    public class MockDataLoja : IData<LojaModel>
    {
        readonly List<LojaModel> itens;

        public MockDataLoja()
        {
            itens = new List<LojaModel>()
            {
                new LojaModel { Id = Guid.NewGuid(), Nome = "Live do Marcão", Email="marcao@email.com", OnLive = true },
                new LojaModel { Id = Guid.NewGuid(), Nome = "Bazar da Vanessa", Email="vanessa@email.com", OnLive = true },
                new LojaModel { Id = Guid.NewGuid(), Nome = "Tudo em Casa", Email="tudoemcasa@email.com", OnLive = true },
                new LojaModel { Id = Guid.NewGuid(), Nome = "Roupas da Lu", Email="lojadalu@email.com", OnLive = true },
            };
        }

        public void SaveMock()
        {
            foreach (var item in itens)
                new LojaRepository().Insert(item);
        }

        public async Task<bool> AddAsync(LojaModel item)
        {
            itens.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(LojaModel item)
        {
            var oldItem = itens.Where((LojaModel arg) => arg.Id == item.Id).FirstOrDefault();
            itens.Remove(oldItem);
            itens.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var oldItem = itens.Where((LojaModel arg) => arg.Id == id).FirstOrDefault();
            itens.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<LojaModel> GetAsync(Guid id)
        {
            return await Task.FromResult(itens.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<LojaModel>> GetAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(itens);
        }
    }
}