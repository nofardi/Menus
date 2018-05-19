using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void TriggerMenuItem()
        {    
            Console.Clear();
            Console.WriteLine("*********{Name}******");
            printSubMenu();
            int selectedTabIndex = getPickedMenuItemFromUser(m_Items);
            activateMenuTab(selectedTabIndex);
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
            throw new NotImplementedException();
        }

        private void activateMenuTab(int selectedTabIndex)
        {
            throw new NotImplementedException();
        }
    }
}