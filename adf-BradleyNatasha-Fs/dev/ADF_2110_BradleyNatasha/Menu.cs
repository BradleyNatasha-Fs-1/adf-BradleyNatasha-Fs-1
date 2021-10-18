using System;
using System.Collections.Generic;
using System.Linq;

namespace ADF_2107_BradleyNatasha
{
    public class Menu
    {
        //Private Member Fields
        private string _title;
        private List<string> _menuitems;

        //Methods

        public void Init(string[] stringArray)
        {

            _menuitems = stringArray.ToList();

            _title = _menuitems[0];
        }


        public void Display()
        {
            //change the colors
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            //print out the menu title and list
            //use a for loop to cycle through list

            //title
            Console.WriteLine("====================");
            Console.WriteLine(_title);
            Console.WriteLine("====================\r\n");

            //cycle through list
            for (int i = 1; i<_menuitems.Count;i++)
            {
                Console.WriteLine($"[{i}] {_menuitems[i]}");
            }

            //report to user
            Console.WriteLine("Select a Menu Option:");
        }
    }
}
