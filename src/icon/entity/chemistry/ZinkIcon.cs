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
            cr.MoveTo(57.988281, 90.695313);
            cr.LineTo(12.675781, 90.695313);
            cr.LineTo(12.675781, 82.332031);
            cr.LineTo(41.859375, 40.433594);
            cr.LineTo(13.445313, 40.433594);
            cr.LineTo(13.445313, 29.765625);
            cr.LineTo(57.222656, 29.765625);
            cr.LineTo(57.222656, 38.128906);
            cr.LineTo(28.039063, 80.027344);
            cr.LineTo(57.988281, 80.027344);
            cr.ClosePath();
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(93.148438, 43.246094);
            cr.CurveTo(98.152344, 43.246094, 102.164063, 44.613281, 105.179688, 47.34375);
            cr.CurveTo(108.195313, 50.019531, 109.703125, 54.339844, 109.703125, 60.316406);
            cr.LineTo(109.703125, 90.695313);
            cr.LineTo(96.988281, 90.695313);
            cr.LineTo(96.988281, 63.472656);
            cr.CurveTo(96.988281, 60.117188, 96.390625, 57.613281, 95.195313, 55.960938);
            cr.CurveTo(94, 54.257813, 92.09375, 53.402344, 89.476563, 53.402344);
            cr.CurveTo(85.609375, 53.402344, 82.964844, 54.738281, 81.542969, 57.414063);
            cr.CurveTo(80.117188, 60.03125, 79.40625, 63.8125, 79.40625, 68.761719);
            cr.LineTo(79.40625, 90.695313);
            cr.LineTo(66.691406, 90.695313);
            cr.LineTo(66.691406, 44.101563);
            cr.LineTo(76.421875, 44.101563);
            cr.LineTo(78.128906, 50.074219);
            cr.LineTo(78.8125, 50.074219);
            cr.CurveTo(80.289063, 47.683594, 82.308594, 45.949219, 84.871094, 44.871094);
            cr.CurveTo(87.484375, 43.789063, 90.246094, 43.246094, 93.148438, 43.246094);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}