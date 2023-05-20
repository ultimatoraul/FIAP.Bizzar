using FIAP.Bizzar.Data;
using FIAP.Bizzar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Bizzar.Services
{
    public class MockDataProduto : IData<ProdutoModel>
    {
        readonly List<ProdutoModel> itens;

        public MockDataProduto()
        {
            itens = new List<ProdutoModel>()
            {
                new ProdutoModel { Id = Guid.NewGuid(), Nome = "Smartphone", Descricao="This is an item description." },
                new ProdutoModel { Id = Guid.NewGuid(), Nome = "Video-Game", Descricao="This is an item description." },
                new ProdutoModel { Id = Guid.NewGuid(), Nome = "Camisa", Descricao="This is an item description." },
                new ProdutoModel { Id = Guid.NewGuid(), Nome = "Tênis", Descricao="This is an item description." },
            };

            foreach (var item in itens)
                new ProdutoRepository().Insert(item);
        }

        public async Task<bool> AddAsync(ProdutoModel item)
        {
            itens.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(ProdutoModel item)
        {
            var oldItem = itens.Where((ProdutoModel arg) => arg.Id == item.Id).FirstOrDefault();
            itens.Remove(oldItem);
            itens.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var oldItem = itens.Where((ProdutoModel arg) => arg.Id == id).FirstOrDefault();
            itens.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ProdutoModel> GetAsync(Guid id)
        {
            return await Task.FromResult(itens.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ProdutoModel>> GetAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(itens);
        }
    }
}