using Cairo;

namespace MoreMapIcons
{
    /**
     * Wolf up icon.
     **/
    public class WolfIcon : Icon
    {
        public float getHeight()
        {
            return 177;
        }

        public float getWidth()
        {
            return 256;
        }

        /**
        * Woof.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(168.335938, 116.925781);
            cr.LineTo(182.109375, 108.164063);
            cr.LineTo(182.117188, 162.808594);
            cr.CurveTo(188.640625, 162.808594, 193.929688, 168.097656, 193.929688, 174.621094);
            cr.LineTo(177.195313, 174.621094);
            cr.CurveTo(177.195313, 168.167969, 173.714844, 162.511719, 168.542969, 159.417969);
            cr.LineTo(168.339844, 159.296875);
            cr.LineTo(168.339844, 116.925781);
            cr.ClosePath();
            cr.MoveTo(42.699219, 132.695313);
            cr.LineTo(58.101563, 174.621094);
            cr.LineTo(77.785156, 174.621094);
            cr.CurveTo(77.785156, 168.097656, 72.5, 162.8125, 65.976563, 162.8125);
            cr.LineTo(59.085938, 133.140625);
            cr.LineTo(87.425781, 112.609375);
            cr.LineTo(73.464844, 110.882813);
            cr.ClosePath();
            cr.MoveTo(249.882813, 28.9375);
            cr.LineTo(246.976563, 29.539063);
            cr.LineTo(234.28125, 26);
            cr.LineTo(230.34375, 18.125);
            cr.LineTo(202.785156, 14.1875);
            cr.LineTo(187.039063, 2.378906);
            cr.LineTo(185.070313, 10.253906);
            cr.LineTo(187.039063, 18.128906);
            cr.LineTo(159.480469, 37.8125);
            cr.LineTo(37.433594, 52.574219);
            cr.LineTo(13.894531, 77.242188);
            cr.LineTo(2, 128.425781);
            cr.LineTo(27.28125, 95.578125);
            cr.LineTo(17.746094, 128.421875);
            cr.LineTo(17.746094, 158.875);
            cr.LineTo(21.683594, 174.621094);
            cr.LineTo(43.339844, 174.621094);
            cr.CurveTo(43.339844, 168.097656, 38.054688, 162.8125, 31.527344, 162.8125);
            cr.LineTo(31.863281, 133.144531);
            cr.LineTo(71.910156, 104.742188);
            cr.LineTo(145.699219, 113.863281);
            cr.LineTo(145.699219, 158.875);
            cr.LineTo(151.605469, 174.621094);
            cr.LineTo(171.289063, 174.621094);
            cr.CurveTo(171.289063, 168.097656, 166.003906, 162.8125, 159.480469, 162.8125);
            cr.LineTo(159.480469, 115.566406);
            cr.LineTo(202.785156, 88.007813);
            cr.LineTo(209.164063, 63.8125);
            cr.LineTo(214.597656, 57.496094);
            cr.LineTo(238.21875, 55.527344);
            cr.LineTo(242.15625, 49.621094);
            cr.LineTo(236.6875, 48.527344);
            cr.LineTo(236.6875, 44.453125);
            cr.CurveTo(236.6875, 44.453125, 234.503906, 46.476563, 233.09375, 47.808594);
            cr.LineTo(222.472656, 45.683594);
            cr.LineTo(226.40625, 41.746094);
            cr.LineTo(234.308594, 44.050781);
            cr.LineTo(236.738281, 41.746094);
            cr.LineTo(240.410156, 41.746094);
            cr.LineTo(240.410156, 46.597656);
            cr.LineTo(246.15625, 41.746094);
            cr.LineTo(250.03125, 41.746094);
            cr.LineTo(253.6875, 33.695313);
            cr.CurveTo(254.84375, 31.148438, 252.617188, 28.367188, 249.882813, 28.9375);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}