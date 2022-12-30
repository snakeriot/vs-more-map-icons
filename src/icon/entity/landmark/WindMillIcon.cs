using Cairo;

namespace MoreMapIcons
{
    /**
     * Wind Mill icon.
     **/
    public class WindMillIcon : Icon
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
        * Draw an icon
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(48.445313, 42.511719);
            cr.LineTo(25.335938, 65.621094);
            cr.LineTo(34.582031, 74.867188);
            cr.LineTo(57.691406, 51.757813);
            cr.LineTo(57.691406, 47.132813);
            cr.LineTo(62.3125, 42.511719);
            cr.LineTo(66.933594, 47.132813);
            cr.LineTo(66.933594, 51.757813);
            cr.LineTo(90.042969, 74.867188);
            cr.LineTo(99.289063, 65.621094);
            cr.LineTo(76.179688, 42.511719);
            cr.LineTo(71.558594, 42.511719);
            cr.LineTo(66.933594, 37.890625);
            cr.LineTo(71.558594, 33.269531);
            cr.LineTo(76.179688, 33.269531);
            cr.LineTo(99.289063, 10.160156);
            cr.LineTo(90.042969, 0.914063);
            cr.LineTo(66.933594, 24.023438);
            cr.LineTo(66.933594, 28.644531);
            cr.LineTo(62.3125, 33.269531);
            cr.LineTo(57.691406, 28.644531);
            cr.LineTo(57.691406, 24.023438);
            cr.LineTo(34.582031, 0.914063);
            cr.LineTo(25.335938, 10.160156);
            cr.LineTo(48.445313, 33.269531);
            cr.LineTo(53.070313, 33.269531);
            cr.LineTo(57.691406, 37.890625);
            cr.LineTo(53.070313, 42.511719);
            cr.ClosePath();
            cr.MoveTo(99.289063, 116.464844);
            cr.LineTo(90.042969, 116.464844);
            cr.LineTo(80.800781, 79.488281);
            cr.LineTo(62.3125, 61);
            cr.LineTo(43.824219, 79.488281);
            cr.LineTo(34.582031, 116.464844);
            cr.LineTo(25.335938, 116.464844);
            cr.CurveTo(22.785156, 116.464844, 20.714844, 118.53125, 20.714844, 121.085938);
            cr.CurveTo(20.714844, 123.636719, 22.785156, 125.707031, 25.335938, 125.707031);
            cr.LineTo(99.289063, 125.707031);
            cr.CurveTo(101.839844, 125.707031, 103.910156, 123.636719, 103.910156, 121.085938);
            cr.CurveTo(103.910156, 118.53125, 101.839844, 116.464844, 99.289063, 116.464844);
            cr.ClosePath();
            cr.MoveTo(66.933594, 116.464844);
            cr.LineTo(57.691406, 116.464844);
            cr.LineTo(57.691406, 102.574219);
            cr.CurveTo(57.691406, 100.035156, 59.75, 97.976563, 62.289063, 97.976563);
            cr.CurveTo(64.855469, 97.976563, 66.933594, 100.054688, 66.933594, 102.621094);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}