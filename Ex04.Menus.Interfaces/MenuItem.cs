namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string m_Name;
        private readonly SubMenuItem m_ItemMenuParent;

        protected MenuItem(string i_MenuItemName, SubMenuItem i_ParentItem)
        {
            m_Name = i_MenuItemName;
            m_ItemMenuParent = i_ParentItem;
        }

        public string Name => m_Name;

        public SubMenuItem ParentItem => m_ItemMenuParent;

        public abstract void TriggerMenuItem();
    }
}
