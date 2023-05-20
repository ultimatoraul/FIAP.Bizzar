using FIAP.Bizzar.Models;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace FIAP.Bizzar.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public ItemDetailViewModel(ProdutoModel itemModel)
        {
            this.ItemId = itemModel.Id;
            this.Name = itemModel.Nome;
            this.Description = itemModel.Descricao;
        }

        private Guid itemId;
        private string name;
        private string description;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Guid ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(Guid itemId)
        {
            try
            {
                var item = await DataStore.GetAsync(itemId);
                ItemId = item.Id;
                Name = item.Nome;
                Description = item.Descricao;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
