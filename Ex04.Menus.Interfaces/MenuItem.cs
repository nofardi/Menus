namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_ItemStr;
        private readonly SubMenuItem r_ParentMenuItem;

        protected MenuItem(string i_MenuItemName, SubMenuItem i_ParentItem)
        {
            r_ItemStr = i_MenuItemName;
            r_ParentMenuItem = i_ParentItem;
        }

        public string ItemStr => r_ItemStr;

        public SubMenuItem ParentItem => r_ParentMenuItem;

        public abstract void TriggerMenuItem();
    }
}
