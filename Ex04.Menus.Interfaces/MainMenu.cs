using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenuItem
    {
        public MainMenu(string i_MenuItemStr, SubMenuItem i_ParentItem, List<MenuItem> i_MenuItems) 
            : base(i_MenuItemStr, i_ParentItem, i_MenuItems)
        {
        }

        public void Show()
        {
            TriggerMenuItem();
        }
    }
}
