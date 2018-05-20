using System;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public class SubActionItem : MenuItem
    {
        private readonly IActionForActionItem m_IActionForActionItem;

        public SubActionItem(string i_MenuItemStr, SubMenuItem i_ParentItem, IActionForActionItem i_IActionForActionItem)
            : base(i_MenuItemStr, i_ParentItem)
        {
            m_IActionForActionItem = i_IActionForActionItem;
        }

        public override void TriggerMenuItem()
        {
            Console.Clear();
            m_IActionForActionItem.ActionMethod();
            ParentItem.TriggerMenuItem();
        }
    }
}
