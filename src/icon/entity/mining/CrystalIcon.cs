using Cairo;

namespace MoreMapIcons
{
    /**
     * Crystal icon.
     **/
    public class CrystalIcon : Icon
    {
        public float getHeight()
        {
            return 256;
        }

        public float getWidth()
        {
            return 256;
        }

        /**
        * Shiny stuff.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(211.300781, 86.898438);
            cr.LineTo(170.800781, 102.601563);
            cr.LineTo(178.300781, 54.800781);
            cr.LineTo(120.601563, 8);
            cr.LineTo(62.898438, 54.699219);
            cr.LineTo(76.199219, 139.101563);
            cr.LineTo(40.699219, 125.199219);
            cr.LineTo(12.898438, 167.300781);
            cr.LineTo(52.898438, 247.898438);
            cr.LineTo(186.800781, 247.898438);
            cr.LineTo(216.398438, 188.101563);
            cr.LineTo(243.101563, 135.398438);
            cr.ClosePath();
            cr.MoveTo(204, 104.101563);
            cr.LineTo(203.699219, 126);
            cr.LineTo(186.101563, 119.5);
            cr.ClosePath();
            cr.MoveTo(81.101563, 238);
            cr.LineTo(60.898438, 155);
            cr.LineTo(46.101563, 137.800781);
            cr.LineTo(78, 150.800781);
            cr.LineTo(91.800781, 238);
            cr.ClosePath();
            cr.MoveTo(77, 56.101563);
            cr.LineTo(105.800781, 32.300781);
            cr.LineTo(95.300781, 57.300781);
            cr.ClosePath();
            cr.MoveTo(140.699219, 238);
            cr.LineTo(147.800781, 166.699219);
            cr.LineTo(154.101563, 146.601563);
            cr.LineTo(127, 162.300781);
            cr.LineTo(127, 238);
            cr.LineTo(115.699219, 238);
            cr.LineTo(106.101563, 59.101563);
            cr.LineTo(120.699219, 20.898438);
            cr.LineTo(167.898438, 58.800781);
            cr.LineTo(154.101563, 146.601563);
            cr.LineTo(175.101563, 169.800781);
            cr.LineTo(153, 238);
            cr.ClosePath();
            cr.MoveTo(179.898438, 238);
            cr.LineTo(171.5, 238);
            cr.LineTo(214.398438, 130.101563);
            cr.LineTo(213.898438, 109.101563);
            cr.LineTo(231.601563, 136.101563);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}