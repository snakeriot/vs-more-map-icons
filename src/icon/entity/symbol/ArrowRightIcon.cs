using Cairo;

namespace MoreMapIcons
{
    /**
     * Arrow right icon.
     **/
    public class ArrowRightIcon : Icon
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
        * Draw an arrow right.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(19, 25.601563);
            cr.CurveTo(18.699219, 25.601563, 18.5, 25.5, 18.199219, 25.398438);
            cr.CurveTo(17.398438, 25.101563, 17, 24.398438, 17, 23.601563);
            cr.LineTo(17, 20);
            cr.LineTo(5, 20);
            cr.CurveTo(3.898438, 20, 3, 19.101563, 3, 18);
            cr.LineTo(3, 14);
            cr.CurveTo(3, 12.898438, 3.898438, 12, 5, 12);
            cr.LineTo(17, 12);
            cr.LineTo(17, 8.398438);
            cr.CurveTo(17, 7.601563, 17.5, 6.898438, 18.199219, 6.601563);
            cr.CurveTo(19, 6.300781, 19.800781, 6.398438, 20.398438, 7);
            cr.LineTo(28.699219, 15.300781);
            cr.CurveTo(29.101563, 15.699219, 29.101563, 16.300781, 28.699219, 16.699219);
            cr.LineTo(20.398438, 25);
            cr.CurveTo(20, 25.398438, 19.5, 25.601563, 19, 25.601563);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}