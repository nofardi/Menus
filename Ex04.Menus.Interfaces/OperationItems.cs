using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class OperationItems : MenuItem
    {
        protected OperationItems(string i_MenuItemName, SubMenuItem i_ParentItem) : base(i_MenuItemName, i_ParentItem)
        {
        }

        public override void TriggerMenuItem()
        {
            throw new NotImplementedException();
        }
    }
}
