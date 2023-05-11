using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MauiApp1.Models;
namespace MauiApp1.Services
{
    public class ItemService : IItemService
    {
        private SQLiteAsyncConnection _dbConnection;

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserItems.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<UserItemModel>();
            }
        }

        public async Task<int> AddItem(UserItemModel useritemModel)
        {
            await SetUpDb();
            return await _dbConnection.InsertAsync(useritemModel);
        }

        public async Task<int> DeleteItem(UserItemModel useritemModel)
        {
            await SetUpDb();
            return await _dbConnection.DeleteAsync(useritemModel);
        }
        public async Task<List<UserItemModel>> GetItemList()
        {
            await SetUpDb();
            var userList = await _dbConnection.Table<UserItemModel>().ToListAsync();
            return userList;
        }

        public async Task<int> UpdateItem(UserItemModel useritemModel)
        {
            await SetUpDb();
            return await _dbConnection.UpdateAsync(useritemModel);
        }
    }
}

