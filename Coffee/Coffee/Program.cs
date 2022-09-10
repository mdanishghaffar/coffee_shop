using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.UI;
using Coffee.BL;
using Coffee.DL;

namespace Coffee
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int option=0;
            do
            {
                option = MainUI.menu();
                if (option == 1)
                {
                    CoffeeShopDL.Shop.addMenuItem(CoffeeShopUI.takeInputMenu());
                }
                else if (option == 2)
                {
                    CoffeeShopUI.printStringValue(CoffeeShopDL.Shop.cheapestItem());
                }
                else if (option == 3)
                {
                    CoffeeShopUI.printStringList(CoffeeShopDL.Shop.drinksOnly());
                }
                else if (option == 4)
                {
                    CoffeeShopUI.printStringList(CoffeeShopDL.Shop.foodOnly());
                }
                else if (option == 5)
                {
                    CoffeeShopDL.Shop.addOrder(CoffeeShopUI.TakeOrder());
                }
                else if (option == 6)
                {
                    CoffeeShopUI.printStringValue(CoffeeShopDL.Shop.fulfillOrder());
                }
                else if (option == 7)
                {
                    CoffeeShopUI.printStringList(CoffeeShopDL.Shop.listOrders());
                }
                else if (option == 8)
                {
                    CoffeeShopUI.printIntValue(CoffeeShopDL.Shop.dueAmount());
                }
            }
            while (option != 9);
            

        }
    }
}
