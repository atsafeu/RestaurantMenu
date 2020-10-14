using System;
namespace RestaurantMenu
{
    public class Menu
    {
  
        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
        }
    }
    
}
