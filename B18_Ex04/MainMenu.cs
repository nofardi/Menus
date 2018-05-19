namespace Ex04.Menus.Delegates
{
    using System.Collections.Generic;
    public class MainMenu : SubMenuItem
    {
        
        public MainMenu(string i_MenuItemStr, SubMenuItem i_ParentItem, List<MenuItem> i_MenuItems)
            :base(i_MenuItemStr, i_ParentItem, i_MenuItems)
        {
        }

        public void Show()
        {
            TriggerMenuItem();
        }
    }
}
