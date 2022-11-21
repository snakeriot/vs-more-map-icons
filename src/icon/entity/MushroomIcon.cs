using Cairo;

namespace MoreMapIcons
{
    /**
     * Pretty mushroom icon, reference taken from toadstool sroom.
     **/
    public class MushroomIcon : Icon
    {
        /**
        * Draw my shroom.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context context)
        {
            context.NewPath();
            context.MoveTo(20, 20);
            context.LineTo(380, 20);
            context.LineTo(200, 380);
            context.LineTo(20, 20);
            context.ClosePath();
        }
    }
}