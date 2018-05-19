using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenuItem : MenuItem
    {
        private const int m_ExitOrBack = 0;
        private readonly List<MenuItem> m_Items;
        
        public SubMenuItem(string i_MenuItemName, SubMenuItem i_ParentItem, List<MenuItem> i_Items)
            : base(i_MenuItemName, i_ParentItem)
        {
            m_Items = i_Items;
        }

        public List<MenuItem> Items => m_Items;

        public SubMenuItem i_ParentItem { get; private set; }

        public override void TriggerMenuItem()
        {    
            Console.Clear();
            Console.WriteLine("*********{Name}******");
            printSubMenu();
            int selectedTabIndex = getPickedMenuItemFromUser(m_Items);
            runUserCoice(selectedTabIndex);
        }

        private void printSubMenu()
        {
            string BackOrExit;
            if (this is MainMenu)
            {
                BackOrExit = "Exit";
            }
            else
            {
                BackOrExit = "Back";
            }

            int menuItemIndex = 0;

            Console.WriteLine("{0} . {1}", menuItemIndex++, BackOrExit);
            foreach (MenuItem menuItem in m_Items)
            {
                Console.WriteLine("{0} . {1}", menuItemIndex++, menuItem.Name);
            }
        }

        private int getPickedMenuItemFromUser(List<MenuItem> items)
        {
            bool isVaild = false;
            int menuItemSelectByUser = 0;
            Console.WriteLine("Please select one of the option from the menu");

            while (!isVaild)
            {
                if (int.TryParse(Console.ReadLine(), out menuItemSelectByUser) && menuItemSelectByUser <= Items.Capacity)
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

        private void runUserCoice(int i_selectedTabIndex)
        {
            if (i_selectedTabIndex == m_ExitOrBack)
            {
                if (this is MainMenu)
                {
                    Environment.Exit(0);
                }
                else
                {
                    ParentItem.TriggerMenuItem();
                }
            }
            else
            {
                Items[i_selectedTabIndex - 1].TriggerMenuItem();
            }         
        }
    }
}