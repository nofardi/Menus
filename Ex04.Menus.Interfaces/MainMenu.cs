using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenuItem
    {
        public MainMenu(string i_MenuItemName, SubMenuItem i_ParentItem, List<MenuItem> i_Items) 
             : base(i_MenuItemName, i_ParentItem, i_Items)
        {
        }

        public void show()
        {
            TriggerMenuItem();
        }
    }
}
