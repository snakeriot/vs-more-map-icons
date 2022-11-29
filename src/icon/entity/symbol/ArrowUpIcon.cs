using Cairo;

namespace MoreMapIcons
{
    /**
     * Arrow up icon.
     **/
    public class ArrowUpIcon : Icon
    {
        public float getHeight()
        {
            return 32;
        }

        public float getWidth()
        {
            return 32;
        }

        /**
        * Draw an arrow up.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(18, 29);
            cr.LineTo(14, 29);
            cr.CurveTo(12.898438, 29, 12, 28.101563, 12, 27);
            cr.LineTo(12, 15);
            cr.LineTo(8.398438, 15);
            cr.CurveTo(7.601563, 15, 6.898438, 14.5, 6.601563, 13.800781);
            cr.CurveTo(6.300781, 13.101563, 6.398438, 12.199219, 7, 11.601563);
            cr.LineTo(15.300781, 3.300781);
            cr.CurveTo(15.699219, 2.898438, 16.300781, 2.898438, 16.699219, 3.300781);
            cr.LineTo(25, 11.601563);
            cr.CurveTo(25.601563, 12.199219, 25.699219, 13, 25.398438, 13.800781);
            cr.CurveTo(25.101563, 14.601563, 24.398438, 15, 23.601563, 15);
            cr.LineTo(20, 15);
            cr.LineTo(20, 27);
            cr.CurveTo(20, 28.101563, 19.101563, 29, 18, 29);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}