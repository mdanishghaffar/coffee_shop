﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.UI
{
    class MainUI
    {
       public static int menu()
        {
            int option=0;
            Console.WriteLine("Welcome to the Tesha’s Coffee Shop\n\n");

            Console.WriteLine("1. Add a Menu item");
            Console.WriteLine("2. View the Cheapest Item in the menu");
            Console.WriteLine("3. View the Drink’s Menu");
            Console.WriteLine("4. View the Food’s Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fulfill the Order");
            Console.WriteLine("7. View the Orders’s List");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
