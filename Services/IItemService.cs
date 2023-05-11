using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;
namespace MauiApp1.Services
{
    public interface IItemService
    {
        Task<List<UserItemModel>> GetItemList();
        Task<int> AddItem(UserItemModel useritemModel);
        Task<int> DeleteItem(UserItemModel useritemModel);
        Task<int> UpdateItem(UserItemModel useritemModel);
    }
}
