using Cairo;

namespace MoreMapIcons
{
    /**
     * Aluminum icon.
     **/
    public class AluminumIcon : Icon
    {
        public float getHeight()
        {
            return 128;
        }

        public float getWidth()
        {
            return 128;
        }

        /**
        * Draw icon.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(67.792969, 100.480469);
            cr.LineTo(62.582031, 83.445313);
            cr.LineTo(36.53125, 83.445313);
            cr.LineTo(31.320313, 100.480469);
            cr.LineTo(14.988281, 100.480469);
            cr.LineTo(40.238281, 28.636719);
            cr.LineTo(58.773438, 28.636719);
            cr.LineTo(84.125, 100.480469);
            cr.ClosePath();
            cr.MoveTo(58.976563, 70.722656);
            cr.LineTo(53.765625, 54.089844);
            cr.CurveTo(53.429688, 52.953125, 52.996094, 51.515625, 52.460938, 49.78125);
            cr.CurveTo(51.925781, 48.042969, 51.394531, 46.273438, 50.859375, 44.46875);
            cr.CurveTo(50.324219, 42.664063, 49.890625, 41.097656, 49.554688, 39.757813);
            cr.CurveTo(49.222656, 41.097656, 48.753906, 42.765625, 48.152344, 44.769531);
            cr.CurveTo(47.617188, 46.707031, 47.085938, 48.578125, 46.550781, 50.382813);
            cr.CurveTo(46.082031, 52.117188, 45.714844, 53.355469, 45.449219, 54.089844);
            cr.LineTo(40.335938, 70.722656);
            cr.ClosePath();
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(106.871094, 100.480469);
            cr.LineTo(91.941406, 100.480469);
            cr.LineTo(91.941406, 24.328125);
            cr.LineTo(106.871094, 24.328125);
            cr.FillPreserve();
        }
    }
}