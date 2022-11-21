using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo("MoreMapIcons",
    Description = "More icons for map markers.",
    Website = "https://github.com/snakeriot/vs-more-map-icons.git",
    Version = "0.0.1",
    Authors = new[] { "dKosher" })]
namespace MoreMapIcons
{
    public class MoreMapIconsMod : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            IconRegistrationService service = new IconRegistrationService(api);
            api.Event.LevelFinalize += service.RegisterIcons;
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
        }
    }
}