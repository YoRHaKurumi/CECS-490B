using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class ItemListViewModel
    {
        public static List<ItemModel> Items { get; private set; } = new List<ItemModel>();
        public ItemListViewModel() 
        {
            Items.Add(new ItemModel { Location ="F2", Name = "Hawaiian Bread", Price = 10, Image = "https://i5.peapod.com/c/MD/MDATH.png" });
            Items.Add(new ItemModel { Location = "T4", Name = "Bread", Price = 5, Image = "https://assets.bonappetit.com/photos/5c62e4a3e81bbf522a9579ce/5:4/w_2815,h_2252,c_limit/milk-bread.jpg" });
            Items.Add(new ItemModel { Location = "A2", Name = "Egg", Price = 3, Image = "https://cdn.britannica.com/94/151894-050-F72A5317/Brown-eggs.jpg"});
            Items.Add(new ItemModel { Location = "B1", Name = "Lays", Price = 2, Image = "https://www.meijer.com/content/dam/meijer/product/0002/84/0019/91/0002840019914_1_A1C1_0600.png"});
            Items.Add(new ItemModel { Location = "C7", Name = "Beef", Price = 20, Image = "https://www.jessicagavin.com/wp-content/uploads/2020/06/cuts-of-beef-12.jpg"});
        }
    }
}
