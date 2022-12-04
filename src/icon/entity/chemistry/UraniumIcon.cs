using Cairo;

namespace MoreMapIcons
{
    /**
     * Uranium icon.
     **/
    public class UraniumIcon : Icon
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
            cr.MoveTo(88.367188, 29.765625);
            cr.LineTo(88.367188, 69.1875);
            cr.CurveTo(88.367188, 73.398438, 87.429688, 77.210938, 85.550781, 80.625);
            cr.CurveTo(83.730469, 83.980469, 80.945313, 86.65625, 77.1875, 88.644531);
            cr.CurveTo(73.433594, 90.578125, 68.742188, 91.546875, 63.109375, 91.546875);
            cr.CurveTo(55.03125, 91.546875, 48.886719, 89.5, 44.675781, 85.402344);
            cr.CurveTo(40.46875, 81.25, 38.363281, 75.789063, 38.363281, 69.019531);
            cr.LineTo(38.363281, 29.765625);
            cr.LineTo(51.246094, 29.765625);
            cr.LineTo(51.246094, 67.054688);
            cr.CurveTo(51.246094, 72.121094, 52.273438, 75.675781, 54.320313, 77.722656);
            cr.CurveTo(56.367188, 79.714844, 59.410156, 80.710938, 63.449219, 80.710938);
            cr.CurveTo(67.660156, 80.710938, 70.703125, 79.601563, 72.582031, 77.382813);
            cr.CurveTo(74.515625, 75.164063, 75.484375, 71.691406, 75.484375, 66.972656);
            cr.LineTo(75.484375, 29.765625);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}