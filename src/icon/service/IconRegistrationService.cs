using System.Linq;
using Vintagestory.API.Client;
using System.Collections.Generic;
using Vintagestory.GameContent;

namespace MoreMapIcons
{
    /**
     * Service that adds all custom icons into the game classes.
     **/
    public class IconRegistrationService
    {
        private ICoreClientAPI _api;
        private Dictionary<string, Icon> _icons;

        /**
         * Default constructor, is needed to initialize dictionary of icons, and store api as a field.
         *
         * @param api {@link ICoreClientAPI}
         **/
        public IconRegistrationService(ICoreClientAPI api)
        {
            this._api = api;
            _icons = new Dictionary<string, Icon>();
            // Flora icons
            _icons.Add("bush", new BushIcon());
            _icons.Add("treeOne", new TreeOneIcon());
            _icons.Add("treeTwo", new TreeTwoIcon());
            _icons.Add("treeThree", new TreeThreeIcon());
            _icons.Add("apple", new AppleIcon());
            _icons.Add("pear", new PearIcon());
            _icons.Add("mushroom", new MushroomIcon());
            // Misceleneous icons
            _icons.Add("skull", new SkullIcon());
        }

        /**
         * Add all new icons to the Map!
         **/
        public void RegisterIcons()
        {
            WorldMapManager manager = _api.ModLoader.GetModSystem<WorldMapManager>();
            WaypointMapLayer wpLayer = manager.MapLayers.FirstOrDefault((MapLayer ml) => ml.GetType() == typeof(WaypointMapLayer)) as WaypointMapLayer;

            if (wpLayer == null)
            {
                return;
            }
            IconRenderService renderService = new IconRenderService();

            foreach (KeyValuePair<string, Icon> entry in _icons)
            {
                wpLayer.WaypointIcons.Add(entry.Key);
                IconUtil iconUtil = _api.Gui.Icons;
                string iconKey = "wp" + char.ToUpper(entry.Key[0]) + entry.Key.Substring(1);

                iconUtil.CustomIcons[iconKey] = (ctx, x, y, w, h, rgba) =>
                {
                    renderService.Render(entry.Value, ctx, x, y, w, h, rgba);
                };
            }
        }
    }
}