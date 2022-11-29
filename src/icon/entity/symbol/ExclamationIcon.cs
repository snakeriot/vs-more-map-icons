using Cairo;

namespace MoreMapIcons
{
    /**
     * Exclamation mark icon.
     **/
    public class ExclamationIcon : Icon
    {
        public float getHeight()
        {
            return 16;
        }

        public float getWidth()
        {
            return 16;
        }

        /**
        * Draw an exclamation mark .
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(6.003906, 14);
            cr.CurveTo(6.003906, 12.894531, 6.898438, 12, 8.003906, 12);
            cr.CurveTo(9.105469, 12, 10.003906, 12.894531, 10.003906, 14);
            cr.CurveTo(10.003906, 15.105469, 9.105469, 16, 8.003906, 16);
            cr.CurveTo(6.898438, 16, 6.003906, 15.105469, 6.003906, 14);
            cr.ClosePath();
            cr.MoveTo(6.195313, 1.988281);
            cr.CurveTo(6.128906, 1.304688, 6.457031, 0.636719, 7.042969, 0.273438);
            cr.CurveTo(7.628906, -0.0898438, 8.367188, -0.0898438, 8.953125, 0.273438);
            cr.CurveTo(9.539063, 0.636719, 9.867188, 1.304688, 9.800781, 1.988281);
            cr.LineTo(9.097656, 9.003906);
            cr.CurveTo(9.042969, 9.570313, 8.566406, 10.003906, 7.996094, 10.003906);
            cr.CurveTo(7.429688, 10.003906, 6.953125, 9.570313, 6.898438, 9.003906);
            cr.LineTo(6.199219, 1.988281);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}