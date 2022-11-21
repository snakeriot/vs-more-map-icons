using Cairo;

namespace MoreMapIcons
{
    public class MushroomIcon
    {
        public static void Render(Context ctx, int x, int y, float w, float h, double[] rgba) {
            ctx.SetSourceRGBA(rgba);
        }
    }
}