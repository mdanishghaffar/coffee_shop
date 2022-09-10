using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee.BL;
using System.IO;

namespace Coffee.DL
{
    class CoffeeShopDL
    {
        public static CoffeeShop Shop = new CoffeeShop("Tesha's");
        public static void store()
        {
            StreamWriter file = new StreamWriter("Coffee.txt");

            file.WriteLine(Shop.getName());
            foreach(var v in Shop.GetMenuList())
                file.WriteLine(v.getName() + ','+v.getPrice() + ',' + v.getFoodOrDrink());
            file.Flush();
            file.Close();
        }
        public static void load()
        {
            StreamReader file = new StreamReader("Coffee.txt");
            Shop.setName(file.ReadLine());
            string r;
            while((r = file.ReadLine()) != null)
            {
                string[] line = r.Split(',');
                Shop.menu.Add(new MenuItem(line[0], line[2], int.Parse(line[1])));
            }
            file.Close();
        }
    }
}
