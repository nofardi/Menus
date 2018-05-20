using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesTest
    {
        private MainMenu m_MainMenu;

        public InterfacesTest()
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
            OperationItems timeAction = new OperationItems("Show Time", showDateTimeMenu, new MenuActions.ShowTimeClass());
            OperationItems dateAction = new OperationItems("Show Date", showDateTimeMenu, new MenuActions.ShowDateClass());
            OperationItems capitalAction = new OperationItems("Count Capitals", versionsCapitalMenu, new MenuActions.ShowCapitalClass());
            OperationItems versionAction = new OperationItems("Show Version", versionsCapitalMenu, new MenuActions.ShowVersionClass());

            showDateTimeMenu.Items.Add(timeAction);
            showDateTimeMenu.Items.Add(dateAction);
            versionsCapitalMenu.Items.Add(capitalAction);
            versionsCapitalMenu.Items.Add(versionAction);

            m_MainMenu.Items.Add(showDateTimeMenu);
            m_MainMenu.Items.Add(versionsCapitalMenu);
        }
    }
}
