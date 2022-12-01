using Cairo;

namespace MoreMapIcons
{
    /**
     * Coal icon.
     **/
    public class CoalIcon : Icon
    {
        public float getHeight()
        {
            return 301;
        }

        public float getWidth()
        {
            return 301;
        }

        /**
        * Burny stuff.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(6.191406, 96.660156);
            cr.CurveTo(2.3125, 99.386719, 0, 103.832031, 0, 108.578125);
            cr.LineTo(0, 227.414063);
            cr.CurveTo(0, 233.484375, 3.765625, 238.921875, 9.449219, 241.050781);
            cr.LineTo(104.09375, 276.542969);
            cr.LineTo(132.664063, 157.453125);
            cr.LineTo(107.328125, 25.605469);
            cr.ClosePath();
            cr.FillPreserve();
            cr.NewPath();
            cr.MoveTo(300.28125, 218);
            cr.LineTo(258.21875, 88.953125);
            cr.LineTo(160.542969, 166.09375);
            cr.LineTo(133.5, 278.84375);
            cr.LineTo(290.226563, 236.574219);
            cr.CurveTo(294.085938, 235.535156, 297.34375, 232.960938, 299.242188, 229.445313);
            cr.CurveTo(301.144531, 225.933594, 301.519531, 221.796875, 300.28125, 218);
            cr.ClosePath();
            cr.FillPreserve();
            cr.NewPath();
            cr.MoveTo(239.121094, 66.917969);
            cr.LineTo(136.328125, 22.15625);
            cr.LineTo(157.339844, 131.507813);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}