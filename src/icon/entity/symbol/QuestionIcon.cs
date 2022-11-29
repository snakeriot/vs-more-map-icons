using Cairo;

namespace MoreMapIcons
{
    /**
     * Question mark icon.
     **/
    public class QuestionIcon : Icon
    {
        public float getHeight()
        {
            return 973;
        }

        public float getWidth()
        {
            return 973;
        }

        /**
        * Draw question mark .
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(502.289063, 788.199219);
            cr.LineTo(455.289063, 788.199219);
            cr.CurveTo(422.191406, 788.199219, 395.289063, 815.097656, 395.289063, 848.199219);
            cr.LineTo(395.289063, 913.097656);
            cr.CurveTo(395.289063, 946.199219, 422.191406, 973.097656, 455.289063, 973.097656);
            cr.LineTo(502.289063, 973.097656);
            cr.CurveTo(535.390625, 973.097656, 562.289063, 946.199219, 562.289063, 913.097656);
            cr.LineTo(562.289063, 848.199219);
            cr.CurveTo(562.289063, 815, 535.390625, 788.199219, 502.289063, 788.199219);
            cr.ClosePath();
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(170.890625, 285.800781);
            cr.LineTo(257.589844, 296.601563);
            cr.CurveTo(285.089844, 300, 311.191406, 284.199219, 321.089844, 258.300781);
            cr.CurveTo(333.589844, 225.601563, 350.988281, 199.800781, 373.289063, 181);
            cr.CurveTo(404.890625, 154.398438, 444.191406, 141, 491.191406, 141);
            cr.CurveTo(539.890625, 141, 578.691406, 153.800781, 607.488281, 179.300781);
            cr.CurveTo(636.289063, 204.898438, 650.589844, 235.5, 650.589844, 271.398438);
            cr.CurveTo(650.589844, 297.199219, 642.488281, 320.800781, 626.289063, 342.199219);
            cr.CurveTo(615.789063, 355.800781, 583.488281, 384.398438, 529.589844, 428.101563);
            cr.CurveTo(475.589844, 471.800781, 439.691406, 511.199219, 421.691406, 546.199219);
            cr.CurveTo(403.289063, 582, 396.890625, 621.699219, 395.289063, 661.5);
            cr.CurveTo(393.890625, 695.601563, 421.089844, 724, 455.289063, 724);
            cr.LineTo(504.289063, 724);
            cr.CurveTo(535.492188, 724, 561.289063, 700.101563, 564.089844, 669.101563);
            cr.CurveTo(566.089844, 646.800781, 569.789063, 629.902344, 575.390625, 618.402344);
            cr.CurveTo(584.789063, 598.699219, 609.089844, 572.699219, 648.089844, 540.300781);
            cr.CurveTo(723.589844, 477.800781, 772.789063, 428.398438, 795.890625, 392);
            cr.CurveTo(818.890625, 355.699219, 830.492188, 317.199219, 830.492188, 276.5);
            cr.CurveTo(830.492188, 203, 799.191406, 138.5, 736.492188, 83.101563);
            cr.CurveTo(673.890625, 27.699219, 589.492188, 0, 483.492188, 0);
            cr.CurveTo(382.691406, 0, 301.390625, 27.300781, 239.390625, 82);
            cr.CurveTo(186.589844, 128.601563, 154.492188, 183.800781, 143.191406, 247.5);
            cr.CurveTo(139.691406, 266.101563, 152.390625, 283.5, 170.890625, 285.800781);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}