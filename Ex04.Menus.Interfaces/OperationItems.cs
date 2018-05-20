using System;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public class OperationItems : MenuItem
    {
        private readonly IActionForLeafItem m_IActionForLeafItem;

        protected OperationItems(string i_MenuItemName, SubMenuItem i_ParentItem, IActionForLeafItem i_AIActionForLeafItem) : base(i_MenuItemName, i_ParentItem)
        {
            m_IActionForLeafItem = i_AIActionForLeafItem;
        }

        public override void TriggerMenuItem()
        {
            Console.Clear();
            m_IActionForLeafItem.ActionMethod();
            Thread.Sleep(2000);
            ParentItem.TriggerMenuItem();
        }
    }
}
