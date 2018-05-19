namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections.Generic;
    public class SubMenuItem : MenuItem
    {
        private const int k_BackOrExitIdx = 0;
        private readonly List<MenuItem> r_MenuItems;

        public SubMenuItem(string i_MenuItemStr, SubMenuItem i_ParentItem, List<MenuItem> i_MenuItems)
            : base(i_MenuItemStr, i_ParentItem)
        {
            r_MenuItems = i_MenuItems;
        }

        public List<MenuItem> MenuItems => r_MenuItems;

        public override void TriggerMenuItem()
        {
            Console.Clear();
            Console.WriteLine($"...{ItemStr}...");
            printSubMenu();
            byte selectedItemIdx = getSelectedMenuItemIndex();
            activateMenuItem(selectedItemIdx);
        }

        private void printSubMenu()
        {
            string backString = this is MainMenu ? "Exit" : "Back";
            byte menuItemIndex = 0;

            Console.WriteLine($"{menuItemIndex++}. {backString}");
            foreach (MenuItem menuItem in MenuItems)
            {
                Console.WriteLine($"{menuItemIndex++}. {menuItem.ItemStr}");
            }
        }

        private byte getSelectedMenuItemIndex()
        {
            byte menuItemIndex;
            bool isValid = false;
            Console.WriteLine("Please choose one of the options above (in numbers).");
            do
            {
                if (byte.TryParse(Console.ReadLine(), out menuItemIndex) && menuItemIndex <= r_MenuItems.Count)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid menu option. Please try again.");
                }
            }
            while (!isValid);

            return menuItemIndex;
        }

        private void activateMenuItem(byte i_SelectedTabIndex)
        {
            if (i_SelectedTabIndex == k_BackOrExitIdx)
            {
                if (this is MainMenu == false)
                {
                    ParentItem.TriggerMenuItem();
                }
            }
            else
            {
                r_MenuItems[i_SelectedTabIndex - 1].TriggerMenuItem();
            }
        }
    }
}
