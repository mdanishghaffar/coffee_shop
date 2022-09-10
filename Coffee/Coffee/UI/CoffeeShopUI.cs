using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.BL;
using Coffee.UI;

namespace Coffee.UI
{
    class CoffeeShopUI
    {
        public static MenuItem takeInputMenu()
        {
            Console.WriteLine("Enter name of Item:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Type:");
            string type = Console.ReadLine();
            while(type != "food" && type != "drink")
            {
                Console.WriteLine("Enter Type:");
                type = Console.ReadLine();
            }
            Console.WriteLine("Enter Price");
            int price = int.Parse(Console.ReadLine());

            MenuItem menuItem = new MenuItem(name,type,price);
            return menuItem;
        }
        public static string TakeOrder()
        {
            Console.WriteLine("Enter item you want to order:");
            string order = Console.ReadLine();
            return order;
        }
        public static void printStringList(List<string> ListToPrint)
        {
            foreach(string v in ListToPrint)
            {
                Console.WriteLine(v);
            }
        }
        public static void printIntValue(int intValue)
        {
            
                Console.WriteLine(intValue);
            
        }
        public static void printStringValue(string stringValue)
        {

            Console.WriteLine(stringValue);

        }
    }
}
