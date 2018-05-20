using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenuItem : MenuItem
    {
        private const int k_ExitOrBack = 0;
        private const int k_ExitCode = 0;
        private readonly List<MenuItem> r_MenuItems;     

        public SubMenuItem(string i_MenuItemStr, SubMenuItem i_ParentItem, List<MenuItem> i_MenuItems)
            : base(i_MenuItemStr, i_ParentItem)
        {
            r_MenuItems = i_MenuItems;
        }

        public List<MenuItem> MenuItems => r_MenuItems;

        public override void TriggerMenuItem()
        {    
            Console.WriteLine($"**** {ItemStr} *****");
            printSubMenu();
            byte selectedItemIdx = getSelectedMenuItemIndex();
            activateMenuItem(selectedItemIdx);
            Console.Clear();
        }

        private void printSubMenu()
        {
            string backOrExitString = this is MainMenu ? "Exit" : "Back";
            byte menuItemIndex = 0;

            Console.WriteLine($"{menuItemIndex++}. {backOrExitString}");
            foreach (MenuItem menuItem in r_MenuItems)
            {
                Console.WriteLine($"{menuItemIndex++}. {menuItem.ItemStr}");
            }
        }

        private byte getSelectedMenuItemIndex()
        {
            bool isVaild = false;
            byte menuItemSelectByUser = 0;
            Console.WriteLine("Please select one of the option from the menu");

            while (!isVaild)
            {
                if (byte.TryParse(Console.ReadLine(), out menuItemSelectByUser) && menuItemSelectByUser <= r_MenuItems.Count)
                {
                    isVaild = true;
                }
                else
                {
                    Console.WriteLine("Invaild Choice - Please try again");
                }
            }

            return menuItemSelectByUser;
        }

        private void activateMenuItem(byte i_SelectedItemIdx)
        {
            if (i_SelectedItemIdx == k_ExitOrBack)
            {
                if (this is MainMenu)
                {
                    Environment.Exit(k_ExitCode);
                }
                else
                {
                    Console.Clear();
                    ParentItem.TriggerMenuItem();
                }
            }
            else
            {
                Console.Clear();
                r_MenuItems[i_SelectedItemIdx - 1].TriggerMenuItem();
            }
        }
    }
}