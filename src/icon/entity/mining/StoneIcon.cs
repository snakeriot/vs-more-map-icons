using Cairo;

namespace MoreMapIcons
{
    /**
     * Stone icon.
     **/
    public class StoneIcon : Icon
    {
        public float getHeight()
        {
            return 512;
        }

        public float getWidth()
        {
            return 512;
        }

        /**
        * Rocky stuff.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(209.875, 44.15625);
            cr.LineTo(27.875, 150.625);
            cr.LineTo(147.5, 204.9375);
            cr.LineTo(295.84375, 216.65625);
            cr.LineTo(337.8125, 192.34375);
            cr.LineTo(355.15625, 203.90625);
            cr.LineTo(309, 230.65625);
            cr.LineTo(309, 379.53125);
            cr.LineTo(362.5625, 364.90625);
            cr.LineTo(297.9375, 416.875);
            cr.LineTo(187.0625, 357.25);
            cr.LineTo(184.90625, 355.71875);
            cr.LineTo(113.625, 362.28125);
            cr.LineTo(189.5625, 330.3125);
            cr.LineTo(290.3125, 382.4375);
            cr.LineTo(290.3125, 234.9375);
            cr.LineTo(144.40625, 223.4375);
            cr.LineTo(142.78125, 223.3125);
            cr.LineTo(141.28125, 222.625);
            cr.LineTo(20.1875, 167.625);
            cr.LineTo(20.1875, 391.46875);
            cr.LineTo(44, 423.1875);
            cr.LineTo(126, 444.15625);
            cr.LineTo(147.875, 422.875);
            cr.LineTo(159.03125, 452.59375);
            cr.LineTo(290.3125, 486.1875);
            cr.LineTo(290.3125, 434);
            cr.LineTo(294.5625, 436.28125);
            cr.LineTo(300.03125, 439.21875);
            cr.LineTo(304.84375, 435.3125);
            cr.LineTo(309, 431.96875);
            cr.LineTo(309, 484.125);
            cr.LineTo(491.375, 377.78125);
            cr.LineTo(491.375, 281.375);
            cr.LineTo(466.78125, 269.46875);
            cr.LineTo(491.375, 230.71875);
            cr.LineTo(491.375, 125);
            cr.LineTo(401.125, 177.28125);
            cr.LineTo(400.03125, 211.375);
            cr.LineTo(312.03125, 152.6875);
            cr.LineTo(397, 158.0625);
            cr.LineTo(476.5, 112);
            cr.LineTo(291.5625, 64.9375);
            cr.LineTo(293.1875, 512);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}