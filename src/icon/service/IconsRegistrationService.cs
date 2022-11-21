using System.Linq;
using Vintagestory.API.Client;
using System.Collections.Generic;
using Cairo;
using Vintagestory.GameContent;

namespace MoreMapIcons
{
    public class IconsRegistrationService
    {
        private ICoreClientAPI _api;
        private delegate void IconRendererDelegate(Context ctx, int x, int y, float w, float h, double[] rgba);
        private Dictionary<string, IconRendererDelegate> _icons;

        public IconsRegistrationService(ICoreClientAPI api)
        {
            this._api = api;
            _icons = new Dictionary<string, IconRendererDelegate>();
            _icons.Add("mushroom", MushroomIcon.Render);
        }

        public void RegisterIcons() {
            WorldMapManager manager = _api.ModLoader.GetModSystem<WorldMapManager>();
            WaypointMapLayer wpLayer = manager.MapLayers.FirstOrDefault((MapLayer ml) => ml.GetType() == typeof(WaypointMapLayer)) as WaypointMapLayer;

            if (wpLayer == null) {
                return;
            }
            foreach(KeyValuePair<string, IconRendererDelegate> entry in _icons)
            {
                
                wpLayer.WaypointIcons.Add(entry.Key);
                    
                IconUtil iconUtil = _api.Gui.Icons;
                string iconKey = "wp" + char.ToUpper(entry.Key[0]) + entry.Key.Substring(1);
                
                iconUtil.CustomIcons[iconKey] = (ctx, x, y, w, h, rgba) => {
                    if (_icons.TryGetValue(entry.Key, out var dele))
                    {
                        ctx.SetSourceRGBA(rgba);
                        dele(ctx, x, y, w, h, rgba);
                        return;
                    }
                };
            }
        }
    }
}