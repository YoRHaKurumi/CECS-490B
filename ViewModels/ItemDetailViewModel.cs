using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    [QueryProperty(nameof(ItemDetail),"ItemDetailObj")]
    public class ItemDetailViewModel : BaseViewModel
    {
        private ItemModel _itemDetail;
        public ItemModel ItemDetail 
        {
            get => _itemDetail;
            set => SetProperty(ref _itemDetail, value);
        }
    }
}
