using Cairo;

namespace MoreMapIcons
{
    /**
     * Arrow down icon.
     **/
    public class ArrowDownIcon : Icon
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
        * Draw an arrow down.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(16, 29);
            cr.CurveTo(15.699219, 29, 15.5, 28.898438, 15.300781, 28.699219);
            cr.LineTo(7, 20.398438);
            cr.CurveTo(6.398438, 19.800781, 6.300781, 19, 6.601563, 18.199219);
            cr.CurveTo(6.898438, 17.398438, 7.601563, 17, 8.398438, 17);
            cr.LineTo(12, 17);
            cr.LineTo(12, 5);
            cr.CurveTo(12, 3.898438, 12.898438, 3, 14, 3);
            cr.LineTo(18, 3);
            cr.CurveTo(19.101563, 3, 20, 3.898438, 20, 5);
            cr.LineTo(20, 17);
            cr.LineTo(23.601563, 17);
            cr.CurveTo(24.398438, 17, 25.101563, 17.5, 25.398438, 18.199219);
            cr.CurveTo(25.699219, 18.898438, 25.5, 19.800781, 25, 20.398438);
            cr.LineTo(16.699219, 28.699219);
            cr.CurveTo(16.5, 28.898438, 16.300781, 29, 16, 29);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}