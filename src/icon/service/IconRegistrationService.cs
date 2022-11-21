using System.Linq;
using Vintagestory.API.Client;
using System.Collections.Generic;
using Vintagestory.GameContent;

namespace MoreMapIcons
{
    public class IconRegistrationService
    {
        private ICoreClientAPI _api;
        private Dictionary<string, Icon> _icons;

        public IconRegistrationService(ICoreClientAPI api)
        {
            this._api = api;
            _icons = new Dictionary<string, Icon>();
            _icons.Add("mushroom", new MushroomIcon());
        }

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