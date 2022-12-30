using Cairo;

namespace MoreMapIcons
{
    /**
     * Potassium icon.
     **/
    public class PotassiumIcon : Icon
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
            cr.MoveTo(113.117188, 117.871094);
            cr.LineTo(86.082031, 117.871094);
            cr.LineTo(56.691406, 70.5625);
            cr.LineTo(46.632813, 77.792969);
            cr.LineTo(46.632813, 117.871094);
            cr.LineTo(22.902344, 117.871094);
            cr.LineTo(22.902344, 5.648438);
            cr.LineTo(46.632813, 5.648438);
            cr.LineTo(46.632813, 57.042969);
            cr.CurveTo(48.207031, 54.84375, 49.777344, 52.644531, 51.347656, 50.445313);
            cr.CurveTo(52.921875, 48.242188, 54.492188, 46.042969, 56.0625, 43.84375);
            cr.LineTo(86.398438, 5.648438);
            cr.LineTo(112.800781, 5.648438);
            cr.LineTo(73.667969, 55.316406);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}