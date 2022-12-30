using Cairo;

namespace MoreMapIcons
{
    /**
     * Phosphorus icon.
     **/
    public class PhosphorusIcon : Icon
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
            cr.MoveTo(65.59375, 7.550781);
            cr.CurveTo(80.238281, 7.550781, 90.898438, 10.734375, 97.582031, 17.101563);
            cr.CurveTo(104.375, 23.359375, 107.769531, 32.007813, 107.769531, 43.042969);
            cr.CurveTo(107.769531, 49.726563, 106.390625, 55.933594, 103.632813, 61.664063);
            cr.CurveTo(100.871094, 67.390625, 96.257813, 72.007813, 89.785156, 75.507813);
            cr.CurveTo(83.417969, 79.007813, 74.71875, 80.761719, 63.683594, 80.761719);
            cr.LineTo(53.339844, 80.761719);
            cr.LineTo(53.339844, 121.183594);
            cr.LineTo(29.308594, 121.183594);
            cr.LineTo(29.308594, 7.550781);
            cr.ClosePath();
            cr.MoveTo(64.320313, 27.285156);
            cr.LineTo(53.339844, 27.285156);
            cr.LineTo(53.339844, 61.027344);
            cr.LineTo(61.296875, 61.027344);
            cr.CurveTo(68.089844, 61.027344, 73.445313, 59.699219, 77.371094, 57.046875);
            cr.CurveTo(81.402344, 54.289063, 83.417969, 49.886719, 83.417969, 43.835938);
            cr.CurveTo(83.417969, 32.804688, 77.054688, 27.285156, 64.320313, 27.285156);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}