using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Services;

namespace MauiApp1.ViewModels
{
    public partial class AddUpdateUserItemDetailViewModel : ObservableObject
    {
        private readonly IItemService _itemService;
        public AddUpdateUserItemDetailViewModel(IItemService itemService) 
        { 
            _itemService= itemService;
        }
        [ObservableProperty]
        private string _ItemName;

        [ObservableProperty]
        private int _Quantity;

        [ICommand]
        public async void AddUpdateItem()
        {
            int response = _itemService.AddItem(new Models.UserItemModel
            {
                ItemName = ItemName,
                Quantity = Quantity,
            });
            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Item Added", "Item added to list", "OK");
            }
            else {
                await Shell.Current.DisplayAlert("Error", "Item could not be added to list", "OK");
            }
        }
    }
}
