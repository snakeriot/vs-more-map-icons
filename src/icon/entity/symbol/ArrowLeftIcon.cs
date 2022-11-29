using Cairo;

namespace MoreMapIcons
{
    /**
     * Arrow left icon.
     **/
    public class ArrowLeftIcon : Icon
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
        * Draw an arrow left.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(13, 25.601563);
            cr.CurveTo(12.5, 25.601563, 12, 25.398438, 11.601563, 25);
            cr.LineTo(3.300781, 16.699219);
            cr.CurveTo(2.898438, 16.300781, 2.898438, 15.699219, 3.300781, 15.300781);
            cr.LineTo(11.601563, 7);
            cr.CurveTo(12.199219, 6.398438, 13, 6.300781, 13.800781, 6.601563);
            cr.CurveTo(14.601563, 6.898438, 15, 7.601563, 15, 8.398438);
            cr.LineTo(15, 12);
            cr.LineTo(27, 12);
            cr.CurveTo(28.101563, 12, 29, 12.898438, 29, 14);
            cr.LineTo(29, 18);
            cr.CurveTo(29, 19.101563, 28.101563, 20, 27, 20);
            cr.LineTo(15, 20);
            cr.LineTo(15, 23.601563);
            cr.CurveTo(15, 24.398438, 14.5, 25.101563, 13.800781, 25.398438);
            cr.CurveTo(13.5, 25.5, 13.300781, 25.601563, 13, 25.601563);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}