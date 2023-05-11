using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
namespace MauiApp1.ViewModels
{
    [QueryProperty(nameof(UseritemDetail), "UseritemDetail")]
    public partial class AddUpdateUserItem : ObservableObject
    {
        [ObservableProperty]
        private UserItemModel _useritemDetail = new UserItemModel();

        private readonly IItemService _itemService;
        public AddUpdateUserItem(IItemService itemService)
        {
            _itemService = itemService;
        }

        [RelayCommand]
        public async void AddUpdateItem()
        {
            int response = -1;
            if (UseritemDetail.Id > 0)
            {
                response = await _itemService.UpdateItem(UseritemDetail);
            }
            else
            {
                response = await _itemService.AddItem(new Models.UserItemModel
                {
                    ItemName = UseritemDetail.ItemName,
                    Quantity = UseritemDetail.Quantity,
                });
            }



            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Item Info Saved", "Record Saved", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Something went wrong while adding record", "OK");
            }
        }

    }
}
