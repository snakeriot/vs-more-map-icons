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
            // Items
            _icons.Add("anvil", new AnvilIcon());
            _icons.Add("chest", new ChestIcon());
            _icons.Add("potion", new PotionIcon());
            _icons.Add("ingots", new IngotsIcon());
            // Flora icons
            _icons.Add("bush", new BushIcon());
            _icons.Add("treeOne", new TreeOneIcon());
            _icons.Add("treeTwo", new TreeTwoIcon());
            _icons.Add("treeThree", new TreeThreeIcon());
            _icons.Add("flowerOne", new FlowerOneIcon());
            _icons.Add("flowerTwo", new FlowerTwoIcon());
            _icons.Add("apple", new AppleIcon());
            _icons.Add("pear", new PearIcon());
            _icons.Add("cherry", new CherryIcon());
            _icons.Add("strawberry", new StrawberryIcon());
            _icons.Add("mushroom", new MushroomIcon());
            _icons.Add("reeds", new ReedsIcon());
            // Fauna
            _icons.Add("goat", new GoatIcon());
            _icons.Add("wolf", new WolfIcon());
            _icons.Add("chicken", new ChickenIcon());
            // Mining
            _icons.Add("coal", new CoalIcon());
            _icons.Add("crystal", new CrystalIcon());
            _icons.Add("diamond", new DiamondIcon());
            _icons.Add("powder", new PowderIcon());
            _icons.Add("salt", new SaltIcon());
            _icons.Add("stone", new StoneIcon());
            _icons.Add("stonePyle", new StonePileIcon());
            // Misceleneous icons
            _icons.Add("skull", new SkullIcon());
            _icons.Add("knifeAndFork", new KnifeAndForkIcon());
            // Symbol icons
            _icons.Add("arrowUp", new ArrowUpIcon());
            _icons.Add("arrowRight", new ArrowRightIcon());
            _icons.Add("arrowDown", new ArrowDownIcon());
            _icons.Add("arrowLeft", new ArrowLeftIcon());
            _icons.Add("exclamationMark", new ExclamationIcon());
            _icons.Add("questionMark", new QuestionIcon());
            // Landmarks
            _icons.Add("campfire", new CampfireIcon());
            _icons.Add("castleRuins", new CastleRuinIcon());
            _icons.Add("mountain", new MountainIcon());
            _icons.Add("swordInStone", new SwordInStoneIcon());
            _icons.Add("thombstone", new ThombstoneIcon());
            // Chemistry
            _icons.Add("argentum", new ArgentumIcon());
            _icons.Add("aurum", new AurumIcon());
            _icons.Add("bismuth", new BismuthIcon());
            _icons.Add("cuprum", new CuprumIcon());
            _icons.Add("ferrum", new FerrumIcon());
            _icons.Add("platinum", new PlatinumIcon());
            _icons.Add("plumbum", new PlumbumIcon());
            _icons.Add("rhodium", new RhodiumIcon());
            _icons.Add("sulfur", new SulfurIcon());
            _icons.Add("uranium", new UraniumIcon());
            _icons.Add("zink", new ZinkIcon());
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