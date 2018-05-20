using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesTests
    {
        private MainMenu m_MainMenu;

        public DelegatesTests()
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
            SubMenuItem showDateTimeMenu = new SubMenuItem("Show Date/ Timer", m_MainMenu, new System.Collections.Generic.List<MenuItem>());
            SubMenuItem versionsCapitalMenu = new SubMenuItem("Version and Capitals", m_MainMenu, new System.Collections.Generic.List<MenuItem>());
            SubActionItem timeAction = new SubActionItem("Show Time", showDateTimeMenu);
            SubActionItem dateAction = new SubActionItem("Show Date", showDateTimeMenu);
            SubActionItem capitalAction = new SubActionItem("Count Capitals", versionsCapitalMenu);
            SubActionItem versionAction = new SubActionItem("Show Version", versionsCapitalMenu);

            showDateTimeMenu.MenuItems.Add(timeAction);
            showDateTimeMenu.MenuItems.Add(dateAction);
            versionsCapitalMenu.MenuItems.Add(capitalAction);
            versionsCapitalMenu.MenuItems.Add(versionAction);

            m_MainMenu.MenuItems.Add(showDateTimeMenu);
            m_MainMenu.MenuItems.Add(versionsCapitalMenu);

            timeAction.ItemClicked += MenuActions.ShowTime;
            dateAction.ItemClicked += MenuActions.ShowDate;
            capitalAction.ItemClicked += MenuActions.ShowCapital;
            versionAction.ItemClicked += MenuActions.ShowVersion;
        }
    }
}
