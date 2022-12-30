using Cairo;

namespace MoreMapIcons
{
    /**
     * Fluorite icon.
     **/
    public class FluoriteIcon : Icon
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
            cr.MoveTo(53.179688, 117.308594);
            cr.LineTo(29.695313, 117.308594);
            cr.LineTo(29.695313, 4.789063);
            cr.LineTo(94.152344, 4.789063);
            cr.LineTo(94.152344, 24.328125);
            cr.LineTo(53.179688, 24.328125);
            cr.LineTo(53.179688, 53.328125);
            cr.LineTo(91.316406, 53.328125);
            cr.LineTo(91.316406, 72.867188);
            cr.LineTo(53.179688, 72.867188);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}