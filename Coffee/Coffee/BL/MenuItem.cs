using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class MenuItem
    {
        private string name;
        private string FoodOrDrink;
        private int price;
        public MenuItem(string name,string FoodorDrink,int price)
        {
            this.name = name;
            this.FoodOrDrink = FoodorDrink;
            this.price = price;
        }
        public string getName() {
            return name;
        }
        public string getFoodOrDrink()
        {
            return FoodOrDrink;
        }
        public int getPrice()
        {
            return price;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setFoodOrDrink(string FoodOrDrink)
        {
            this.FoodOrDrink = FoodOrDrink;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
    }
}
