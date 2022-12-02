using Cairo;

namespace MoreMapIcons
{
    /**
     * Anvil icon.
     **/
    public class AnvilIcon : Icon
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
        * Draw anvil.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(248, 91.300781);
            cr.LineTo(248, 67);
            cr.LineTo(80, 67);
            cr.LineTo(80, 75);
            cr.LineTo(9, 75);
            cr.CurveTo(9, 75, 19.699219, 115.601563, 76.300781, 115.601563);
            cr.CurveTo(106.601563, 115.601563, 110.699219, 128.300781, 110.699219, 134.699219);
            cr.CurveTo(110.699219, 143.101563, 105.601563, 156.601563, 74, 167.5);
            cr.LineTo(74, 191);
            cr.LineTo(112.699219, 191);
            cr.CurveTo(119.5, 185.800781, 128, 182.800781, 137.199219, 182.800781);
            cr.CurveTo(146.398438, 182.800781, 154.898438, 185.898438, 161.699219, 191);
            cr.LineTo(201, 191);
            cr.CurveTo(201, 191, 201, 175.898438, 201, 168.101563);
            cr.CurveTo(177.601563, 160.398438, 162.300781, 147.699219, 162.300781, 133.300781);
            cr.CurveTo(162.300781, 110.601563, 200.101563, 92.5, 248, 91.300781);
            cr.ClosePath();
            cr.MoveTo(80, 87);
            cr.CurveTo(28, 87, 28, 83, 28, 83);
            cr.LineTo(80, 83);
            cr.CurveTo(80, 83, 80, 85.398438, 80, 87);
            cr.ClosePath();
            cr.MoveTo(88, 79);
            cr.LineTo(88, 75);
            cr.LineTo(240, 75);
            cr.LineTo(240, 79);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}