
using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.SearchHandlers
{
    public class ItemSearchHandler: SearchHandler
    {
        public IList<ItemModel> Items { get; set; }
        
        public string NavigationRoute { get; set; }
        public Type NavigationType { get; set; }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else 
            {
                ItemsSource = Items.Where(items => items.Name.ToLower().Contains(newValue.ToLower())).ToList<ItemModel>();    
            }
        }
        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            if(!string.IsNullOrWhiteSpace(NavigationRoute))
            {
                var navParam = new Dictionary<string, object> 
                {
                    {"ItemDetailObj", item }
                };
                await Shell.Current.GoToAsync(NavigationRoute,navParam );
            }
        }
    }
}
