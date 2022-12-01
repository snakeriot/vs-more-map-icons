using Cairo;

namespace MoreMapIcons
{
    /**
     * Sword in stone icon.
     **/
    public class SwordInStoneIcon : Icon
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
        * Rocky swordy.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(101.9375, 19.9375);
            cr.CurveTo(93.101563, 19.9375, 86.125, 26.914063, 86.125, 35.75);
            cr.CurveTo(86.125, 43.109375, 90.964844, 49.175781, 97.6875, 51);
            cr.LineTo(120.820313, 106.398438);
            cr.CurveTo(108.203125, 113.765625, 97.757813, 126.25, 90.652344, 143.929688);
            cr.LineTo(64.21875, 163.75);
            cr.LineTo(75.4375, 178.6875);
            cr.LineTo(83.613281, 172.554688);
            cr.CurveTo(115.335938, 151.441406, 156.015625, 132.566406, 193.734375, 122.578125);
            cr.LineTo(221.0625, 118.5);
            cr.LineTo(218.28125, 100);
            cr.LineTo(184.988281, 104.980469);
            cr.CurveTo(171.976563, 100.023438, 159.835938, 97.886719, 148.875, 98.375);
            cr.CurveTo(145.203125, 262.375, 141.671875, 160.375, 138.273438, 99.710938);
            cr.LineTo(115.1875, 44.40625);
            cr.CurveTo(116.785156, 41.925781, 117.71875, 38.96875, 117.71875, 35.75);
            cr.CurveTo(117.71875, 26.910156, 110.773438, 19.9375, 101.9375, 19.9375);
            cr.ClosePath();
            cr.MoveTo(178.808594, 147);
            cr.CurveTo(161.097656, 153.109375, 142.902344, 160.921875, 125.933594, 169.65625);
            cr.LineTo(194.34375, 334.6875);
            cr.LineTo(208.96875, 326.84375);
            cr.LineTo(237.246094, 288.09375);
            cr.LineTo(178.8125, 147);
            cr.ClosePath();
            cr.MoveTo(347.902344, 258.53125);
            cr.LineTo(279.777344, 261.5625);
            cr.LineTo(222.8125, 339.5625);
            cr.LineTo(221.5625, 341.28125);
            cr.LineTo(219.6875, 342.3125);
            cr.LineTo(154.375, 377.34375);
            cr.LineTo(125.902344, 494.53125);
            cr.LineTo(471.152344, 494.53125);
            cr.LineTo(456.152344, 430.847656);
            cr.LineTo(290.59375, 376.15625);
            cr.LineTo(296.46875, 358.40625);
            cr.LineTo(386.371094, 388.097656);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}