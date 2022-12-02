using Cairo;

namespace MoreMapIcons
{
    /**
     * Ingots icon.
     **/
    public class IngotsIcon : Icon
    {
        public float getHeight()
        {
            return 48;
        }

        public float getWidth()
        {
            return 48;
        }

        /**
        * Draw ingots.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(22.21875, 7.378906);
            cr.LineTo(33.886719, 16.621094);
            cr.LineTo(36.179688, 24);
            cr.LineTo(25.261719, 26.085938);
            cr.LineTo(12.589844, 14.53125);
            cr.LineTo(15.28125, 9);
            cr.ClosePath();
            cr.StrokePreserve();

            cr.NewPath();
            cr.MoveTo(15.28125, 9);
            cr.LineTo(26.484375, 18.601563);
            cr.StrokePreserve();

            cr.NewPath();
            cr.MoveTo(25.261719, 26.085938);
            cr.LineTo(26.488281, 18.132813);
            cr.LineTo(33.886719, 16.621094);
            cr.StrokePreserve();

            cr.NewPath();
            cr.MoveTo(24.992188, 31.023438);
            cr.LineTo(27.277344, 38.101563);
            cr.LineTo(15.601563, 40.378906);
            cr.LineTo(4, 29.015625);
            cr.LineTo(6.570313, 22.625);
            cr.LineTo(12.027344, 21.351563);
            cr.StrokePreserve();

            cr.NewPath();
            cr.StrokePreserve();

            cr.NewPath();
            cr.MoveTo(15.601563, 39.863281);
            cr.LineTo(17.488281, 32.132813);
            cr.LineTo(24.992188, 31.042969);
            cr.StrokePreserve();

            cr.NewPath();
            cr.MoveTo(34.886719, 29.609375);
            cr.LineTo(34, 36.800781);
            cr.LineTo(43.234375, 35);
            cr.LineTo(41.28125, 28.1875);
            cr.ClosePath();
            cr.StrokePreserve();
        }
    }
}