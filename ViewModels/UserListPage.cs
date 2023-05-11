using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using MauiApp1.Views;
namespace MauiApp1.ViewModels
{
    public partial class UserListPage : ObservableObject
    {
        public static List<UserItemModel> ItemsListForSearch { get; private set; } = new List<UserItemModel>();
        public ObservableCollection<UserItemModel> UserItem { get; set; } = new ObservableCollection<UserItemModel>();

        private readonly IItemService _itemService;
        public UserListPage(IItemService itemService)
        {
            _itemService = itemService;
        }



        [RelayCommand]
        public async void GetItemList()
        {
            UserItem.Clear();
            var itemList = await _itemService.GetItemList();
            if (itemList?.Count > 0)
            {
                itemList = itemList.OrderBy(f => f.ItemName).ToList();
                foreach (var item in itemList)
                {
                    UserItem.Add(item);
                }
                ItemsListForSearch.Clear();
                ItemsListForSearch.AddRange(itemList);
            }
        }

        [RelayCommand]
        public async void AddUpdateItem()
        {
            await Shell.Current.GoToAsync(nameof(AddUpdateUserItemDetail));
        }

        [RelayCommand]
        public async void EditItem(UserItemModel userItemModel)
        {
            var navParam = new Dictionary<string, object>();
            navParam.Add("UseritemDetail", userItemModel);
            await Shell.Current.GoToAsync(nameof(AddUpdateUserItemDetail), navParam);
        }

        [RelayCommand]
        public async void DeleteItem(UserItemModel userItemModel)
        {
            var delResponse = await _itemService.DeleteItem(userItemModel);
            if (delResponse > 0)
            {
                GetItemList();
            }
        }
        [RelayCommand]
        public async void DisplayAction(UserItemModel userItemModel)
        {
            var response = await Shell.Current.DisplayActionSheet("Select Option", "OK", null, "Edit", "Delete");
            if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>();
                navParam.Add("UseritemDetail", userItemModel);
                await Shell.Current.GoToAsync(nameof(AddUpdateUserItemDetail), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse = await _itemService.DeleteItem(userItemModel);
                if (delResponse > 0)
                {
                    GetItemList();
                }
            }
        }
    }
}
