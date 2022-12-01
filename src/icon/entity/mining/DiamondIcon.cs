using Cairo;

namespace MoreMapIcons
{
    /**
     * Diamond icon.
     **/
    public class DiamondIcon : Icon
    {
        public float getHeight()
        {
            return 491;
        }

        public float getWidth()
        {
            return 491;
        }

        /**
        * Expensive stuff.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(491, 165.101563);
            cr.LineTo(427.101563, 22.601563);
            cr.LineTo(63.898438, 22.601563);
            cr.LineTo(0, 165.101563);
            cr.LineTo(245.5, 468.398438);
            cr.ClosePath();
            cr.MoveTo(182.898438, 187.101563);
            cr.LineTo(308.199219, 187.101563);
            cr.LineTo(245.5, 371);
            cr.ClosePath();
            cr.MoveTo(302.800781, 315.300781);
            cr.LineTo(346.5, 187.101563);
            cr.LineTo(406.601563, 187.101563);
            cr.ClosePath();
            cr.MoveTo(402, 93.300781);
            cr.LineTo(420.800781, 135.300781);
            cr.LineTo(373.601563, 135.300781);
            cr.ClosePath();
            cr.MoveTo(371, 74.398438);
            cr.LineTo(333.199219, 130.398438);
            cr.LineTo(289, 74.398438);
            cr.CurveTo(289, 74.398438, 371, 74.398438, 371, 74.398438);
            cr.ClosePath();
            cr.MoveTo(290.800781, 135.300781);
            cr.LineTo(200.101563, 135.300781);
            cr.LineTo(245.5, 77.800781);
            cr.ClosePath();
            cr.MoveTo(202, 74.398438);
            cr.LineTo(157.800781, 130.398438);
            cr.LineTo(120, 74.398438);
            cr.CurveTo(120, 74.398438, 202, 74.398438, 202, 74.398438);
            cr.ClosePath();
            cr.MoveTo(89, 93.300781);
            cr.LineTo(117.300781, 135.300781);
            cr.LineTo(70.199219, 135.300781);
            cr.ClosePath();
            cr.MoveTo(84.398438, 187.101563);
            cr.LineTo(144.5, 187.101563);
            cr.LineTo(188.199219, 315.300781);
            cr.ClosePath();
            cr.MoveTo(84.398438, 187.101563);
            cr.FillPreserve();
        }
    }
}