﻿namespace Ability.AbilityMenu.Menus.NukesMenu
{
    using Ability.AbilityMenu.Items;

    using Ensage.Common.Menu;

    internal class NukeMenu
    {
        #region Public Methods and Operators

        public static Menu Create(string name)
        {
            var menu = new Menu(name, name, textureName: name);
            menu.AddItem(Togglers.UseOn(name));
            menu.AddItem(Sliders.MinHealth(name));
            if (name == "zuus_thundergods_wrath")
            {
                menu.AddItem(
                    new MenuItem(name + "minenemykill", "Minimum heroes to kill: ").SetValue(new Slider(1, 1, 5)));
            }
            menu.AddItem(
                new MenuItem(name + "combo", "Use in combo: ").SetValue(true)
                    .SetTooltip("Allows the ability to be used along with other nukes in combo when killstealing"));
            return menu;
        }

        #endregion
    }
}