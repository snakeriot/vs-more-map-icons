using Cairo;

namespace MoreMapIcons
{
    /**
     * Mountain icon.
     **/
    public class MountainIcon : Icon
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
        * Rocky rock.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(508.300781, 486.597656);
            cr.LineTo(384.191406, 283.511719);
            cr.CurveTo(377.683594, 272.863281, 362.195313, 272.863281, 355.691406, 283.511719);
            cr.LineTo(335.800781, 316.058594);
            cr.LineTo(429.375, 469.183594);
            cr.CurveTo(437.296875, 482.183594, 438.730469, 497.933594, 433.765625, 512);
            cr.LineTo(494.050781, 512);
            cr.CurveTo(507.101563, 512, 515.0625, 497.691406, 508.300781, 486.597656);
            cr.ClosePath();
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(400.886719, 486.597656);
            cr.LineTo(217.234375, 186.074219);
            cr.CurveTo(210.726563, 175.429688, 195.238281, 175.429688, 188.734375, 186.074219);
            cr.LineTo(5.082031, 486.597656);
            cr.CurveTo(-1.679688, 497.691406, 6.28125, 512, 19.332031, 512);
            cr.LineTo(386.636719, 512);
            cr.CurveTo(399.6875, 512, 407.648438, 497.691406, 400.886719, 486.597656);
            cr.ClosePath();
            cr.MoveTo(236.375, 338.125);
            cr.LineTo(214.789063, 316.542969);
            cr.CurveTo(208.265625, 310.019531, 197.699219, 310.019531, 191.179688, 316.542969);
            cr.LineTo(169.589844, 338.125);
            cr.LineTo(148.089844, 316.625);
            cr.LineTo(202.980469, 226.796875);
            cr.LineTo(257.871094, 316.625);
            cr.ClosePath();
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(191.515625, 54.75);
            cr.CurveTo(183.863281, 43.15625, 172.058594, 36.015625, 158.113281, 34.234375);
            cr.CurveTo(146.484375, 13.363281, 124.398438, 0, 100.027344, 0);
            cr.CurveTo(75.65625, 0, 53.570313, 13.371094, 41.941406, 34.238281);
            cr.CurveTo(28.007813, 36.023438, 16.203125, 43.167969, 8.550781, 54.765625);
            cr.CurveTo(-11.519531, 85.199219, 5.171875, 133.566406, 49.941406, 133.566406);
            cr.LineTo(150.113281, 133.566406);
            cr.CurveTo(194.75, 133.566406, 211.652344, 85.261719, 191.515625, 54.75);
            cr.ClosePath();
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(445.070313, 0);
            cr.CurveTo(420.652344, 0, 398.789063, 13.46875, 387.140625, 33.996094);
            cr.CurveTo(384.234375, 33.601563, 381.28125, 33.390625, 378.289063, 33.390625);
            cr.CurveTo(353.917969, 33.390625, 331.832031, 46.761719, 320.203125, 67.632813);
            cr.CurveTo(306.265625, 69.414063, 294.460938, 76.558594, 286.808594, 88.15625);
            cr.CurveTo(266.742188, 118.589844, 283.433594, 166.957031, 328.203125, 166.957031);
            cr.LineTo(428.375, 166.957031);
            cr.CurveTo(453.933594, 166.957031, 473.503906, 150.46875, 477.371094, 125.171875);
            cr.CurveTo(498.355469, 113.5625, 511.855469, 91.363281, 511.855469, 66.78125);
            cr.CurveTo(511.851563, 29.957031, 481.894531, 0, 445.070313, 0);
            cr.ClosePath();

            cr.MoveTo(470.113281, 88.742188);
            cr.CurveTo(469.988281, 88.546875, 469.90625, 88.332031, 469.777344, 88.140625);
            cr.CurveTo(462.125, 76.550781, 450.320313, 69.40625, 436.375, 67.625);
            cr.CurveTo(431.8125, 59.4375, 425.601563, 52.460938, 418.3125, 46.9375);
            cr.CurveTo(424.480469, 38.648438, 434.28125, 33.390625, 445.070313, 33.390625);
            cr.CurveTo(463.484375, 33.390625, 478.460938, 48.367188, 478.460938, 66.78125);
            cr.CurveTo(478.460938, 75.078125, 475.328125, 82.789063, 470.113281, 88.742188);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}