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
            cr.MoveTo(109.671875, 3.445313);
            cr.LineTo(109.671875, 76.460938);
            cr.CurveTo(109.671875, 84.257813, 107.933594, 91.316406, 104.457031, 97.636719);
            cr.CurveTo(101.082031, 103.851563, 95.921875, 108.804688, 88.96875, 112.492188);
            cr.CurveTo(82.015625, 116.074219, 73.320313, 117.867188, 62.890625, 117.867188);
            cr.CurveTo(47.929688, 117.867188, 36.550781, 114.074219, 28.753906, 106.488281);
            cr.CurveTo(20.957031, 98.796875, 17.058594, 88.683594, 17.058594, 76.144531);
            cr.LineTo(17.058594, 3.445313);
            cr.LineTo(40.921875, 3.445313);
            cr.LineTo(40.921875, 72.507813);
            cr.CurveTo(40.921875, 81.886719, 42.820313, 88.472656, 46.613281, 92.265625);
            cr.CurveTo(50.40625, 95.953125, 56.042969, 97.796875, 63.523438, 97.796875);
            cr.CurveTo(71.320313, 97.796875, 76.957031, 95.742188, 80.433594, 91.632813);
            cr.CurveTo(84.015625, 87.523438, 85.808594, 81.097656, 85.808594, 72.351563);
            cr.LineTo(85.808594, 3.445313);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}