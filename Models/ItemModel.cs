
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models
{
    
    public class ItemModel
    {
        
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
