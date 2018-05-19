namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly string r_ItemStr;
        private readonly SubMenuItem r_ParentMenuItem;

        protected MenuItem(string i_MenuItemStr, SubMenuItem i_ParentMenuItem)
        {
            r_ItemStr = i_MenuItemStr;
            r_ParentMenuItem = i_ParentMenuItem;
        }

        public string ItemStr => r_ItemStr;

        public SubMenuItem ParentItem => r_ParentMenuItem;

        public abstract void TriggerMenuItem();
    }
}
