using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee;

namespace Coffee.BL
{
    class CoffeeShop
    {
        private string name;
        public List<MenuItem> menu = new List<MenuItem>();
        private List<string> orders = new List<string>();

        public List<MenuItem> GetMenuList()
        {
            return menu;
        }
        public List<string> getOrdersList()
        {
            return orders;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public CoffeeShop(string name)
        {
            this.name = name;
        }
        public void addMenuItem(MenuItem item)
        {
            menu.Add(item);
        }
        public bool addOrder(string order)
        {
            bool check = checkAvailableOnMenu(order);
            if (check == true)
            {
                orders.Add(order);
                return true;
            }
            return false;

        }
        public bool checkAvailableOnMenu(string order)
        {
            foreach(MenuItem item in menu)
            {
                if (order == item.getName()) {
                    return true;
                }
            }
            return false;
        }
        public string fulfillOrder()
        {
            if (orders.Count != 0)
            {
                string s = $"The {orders[0]} is Ready";
                orders.Remove(orders[0]);
                return s;
            }
            else {
                return "All orders have been fulfilled";
            }
        }
        public List<string> listOrders() {
        if(orders.Count > 0)
            {
                return orders;
            }
            return null;
        }
        public int dueAmount()
        {
            int sum = 0;
                foreach (MenuItem item in menu)
                {
                    
                    sum = sum + item.getPrice();
                }
            return sum;   
        }
        public  string cheapestItem()
        {
            int cheapest = menu[0].getPrice();
            string nameOfCheapest = menu[0].getName();
            for(int i = 0; i < menu.Count; i++)
            {
                if(menu[i].getPrice() < cheapest)
                {
                    cheapest = menu[i].getPrice();
                    nameOfCheapest = menu[i].getName();
                }
            }
            return nameOfCheapest;
        }
        public List<string> drinksOnly()
        {
            List<string> drinks = new List<string>();
          
            foreach (MenuItem item in menu)
            {

                if(item.getFoodOrDrink() == "drink")
                {
                    drinks.Add(item.getName());
                }
            }
            return drinks;
            
        }
        public List<string> foodOnly()
        {
            List<string> food = new List<string>();

            foreach (MenuItem item in menu)
            {
                if (item.getFoodOrDrink() == "food")
                {
                    food.Add(item.getName());
                }
            }
            return food;

        }
    }
}
