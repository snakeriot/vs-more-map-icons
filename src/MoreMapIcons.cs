using System.Linq;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;
using Vintagestory.GameContent;

[assembly: ModInfo("MoreMapIcons",
    Description = "More icons for map markers.",
    Website = "https://github.com/snakeriot/vs-more-map-icons.git",
    Version = "0.0.1",
    Authors = new[] { "dKosher" })]
namespace MoreMapIcons
{
    public class MoreMapIconsMod : ModSystem
    {
        private ICoreClientAPI _api;
        public override void Start(ICoreAPI api)
        {
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            _api = api;
            api.Event.LevelFinalize += OnClientReady;
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
        }

        private void OnClientReady()
        {
        }
    }
}