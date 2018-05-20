namespace Ex04.Menus.Delegates
{
    using System;

    public class SubActionItem : MenuItem
    {
        public event Action ItemClicked;

        public SubActionItem(string i_MenuItemStr, SubMenuItem i_ParentMenuItem)
            : base(i_MenuItemStr, i_ParentMenuItem)
        {
        }

        public override void TriggerMenuItem()
        {
            Console.Clear();
            OnClicked();
            ParentItem.TriggerMenuItem();
        }

        protected virtual void OnClicked()
        {
            if(ItemClicked != null)
            {
                ItemClicked.Invoke();
            }
            else
            {
                throw new NotImplementedException("Empty delegate.");
            }
        }
    }
}
