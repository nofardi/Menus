using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesTests
    {
        private MainMenu m_MainMenu;

        public InterfacesTests()
        {
            buildMenu();
        }

        public void RunTests()
        {
            m_MainMenu.Show();
        }

        private void buildMenu()
        {
            m_MainMenu = new MainMenu("Main menu", null, new System.Collections.Generic.List<MenuItem>());
            SubMenuItem showDateTimeMenu = new SubMenuItem("Show Date/ Time", m_MainMenu, new System.Collections.Generic.List<MenuItem>());
            SubMenuItem versionsCapitalMenu = new SubMenuItem("Version and Capitals", m_MainMenu, new System.Collections.Generic.List<MenuItem>());
            SubActionItem timeAction = new SubActionItem("Show Time", showDateTimeMenu, new MenuActions.ShowTimeClass());
            SubActionItem dateAction = new SubActionItem("Show Date", showDateTimeMenu, new MenuActions.ShowDateClass());
            SubActionItem capitalAction = new SubActionItem("Count Capitals", versionsCapitalMenu, new MenuActions.ShowCapitalClass());
            SubActionItem versionAction = new SubActionItem("Show Version", versionsCapitalMenu, new MenuActions.ShowVersionClass());

            showDateTimeMenu.MenuItems.Add(timeAction);
            showDateTimeMenu.MenuItems.Add(dateAction);
            versionsCapitalMenu.MenuItems.Add(capitalAction);
            versionsCapitalMenu.MenuItems.Add(versionAction);

            m_MainMenu.MenuItems.Add(showDateTimeMenu);
            m_MainMenu.MenuItems.Add(versionsCapitalMenu);
        }
    }
}
