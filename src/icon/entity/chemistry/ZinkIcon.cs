using Cairo;

namespace MoreMapIcons
{
    /**
     * Zink icon.
     **/
    public class ZinkIcon : Icon
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
            cr.MoveTo(60.035156, 97.414063);
            cr.LineTo(5.902344, 97.414063);
            cr.LineTo(5.902344, 87.425781);
            cr.LineTo(40.769531, 37.371094);
            cr.LineTo(6.820313, 37.371094);
            cr.LineTo(6.820313, 24.625);
            cr.LineTo(59.117188, 24.625);
            cr.LineTo(59.117188, 34.617188);
            cr.LineTo(24.253906, 84.671875);
            cr.LineTo(60.035156, 84.671875);
            cr.ClosePath();
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(102.039063, 40.734375);
            cr.CurveTo(108.019531, 40.734375, 112.808594, 42.363281, 116.414063, 45.628906);
            cr.CurveTo(120.015625, 48.820313, 121.816406, 53.988281, 121.816406, 61.121094);
            cr.LineTo(121.816406, 97.414063);
            cr.LineTo(106.625, 97.414063);
            cr.LineTo(106.625, 64.894531);
            cr.CurveTo(106.625, 60.886719, 105.910156, 57.894531, 104.484375, 55.921875);
            cr.CurveTo(103.058594, 53.886719, 100.78125, 52.867188, 97.65625, 52.867188);
            cr.CurveTo(93.03125, 52.867188, 89.871094, 54.460938, 88.171875, 57.65625);
            cr.CurveTo(86.472656, 60.78125, 85.625, 65.304688, 85.625, 71.214844);
            cr.LineTo(85.625, 97.414063);
            cr.LineTo(70.433594, 97.414063);
            cr.LineTo(70.433594, 41.753906);
            cr.LineTo(82.058594, 41.753906);
            cr.LineTo(84.09375, 48.890625);
            cr.LineTo(84.910156, 48.890625);
            cr.CurveTo(86.679688, 46.035156, 89.089844, 43.960938, 92.148438, 42.671875);
            cr.CurveTo(95.277344, 41.378906, 98.570313, 40.734375, 102.039063, 40.734375);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}