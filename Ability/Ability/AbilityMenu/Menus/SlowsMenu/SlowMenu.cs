﻿namespace Ability.AbilityMenu.Menus.SlowsMenu
{
    using Ability.AbilityMenu.Items;

    using Ensage.Common.Menu;

    internal class SlowMenu
    {
        #region Public Methods and Operators

        public static Menu Create(string name)
        {
            var menu = new Menu(name, name, textureName: name);
            menu.AddItem(Togglers.OnSight(name));
            menu.AddItem(Togglers.UnderTower(name));
            menu.AddItem(Togglers.OnChainStun(name));
            return menu;
        }

        #endregion
    }
}