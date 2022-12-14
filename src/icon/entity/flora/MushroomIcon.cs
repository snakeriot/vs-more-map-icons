using Cairo;

namespace MoreMapIcons
{
    /**
     * Pretty mushroom icon, reference taken from toadstool sroom.
     **/
    public class MushroomIcon : Icon
    {
        public float getHeight()
        {
            return 330;
        }

        public float getWidth()
        {
            return 330;
        }

        /**
        * Draw my shroom.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(165.089844, 0);
            cr.CurveTo(88.445313, 0, 26.316406, 57.804688, 26.316406, 129.109375);
            cr.CurveTo(26.316406, 133.203125, 26.53125, 164.066406, 26.929688, 168.066406);
            cr.CurveTo(26.929688, 168.066406, 31.101563, 185.941406, 165.089844, 185.941406);
            cr.CurveTo(300.671875, 185.941406, 303.246094, 168.066406, 303.246094, 168.066406);
            cr.CurveTo(303.648438, 164.066406, 303.863281, 133.203125, 303.863281, 129.109375);
            cr.CurveTo(303.863281, 57.804688, 241.730469, 0, 165.089844, 0);
            cr.ClosePath();
            cr.MoveTo(121.425781, 41.464844);
            cr.CurveTo(109.492188, 44.269531, 98.152344, 50.292969, 88.148438, 58.476563);
            cr.CurveTo(64.972656, 77.4375, 56.023438, 104.960938, 58.175781, 134.375);
            cr.CurveTo(58.71875, 141.789063, 47.195313, 141.738281, 46.65625, 134.375);
            cr.CurveTo(44.347656, 102.828125, 54.375, 71.300781, 79.359375, 50.855469);
            cr.CurveTo(90.539063, 41.710938, 104.144531, 33.699219, 118.363281, 30.359375);
            cr.CurveTo(125.589844, 28.660156, 128.65625, 39.769531, 121.425781, 41.464844);
            cr.ClosePath();
            cr.MoveTo(121.425781, 41.464844);
            cr.FillPreserve();

            cr.NewPath();
            cr.MoveTo(206.988281, 194.84375);
            cr.CurveTo(193.152344, 195.359375, 181.761719, 195.621094, 165.089844, 195.621094);
            cr.CurveTo(150.199219, 195.621094, 138.433594, 195.394531, 123.191406, 194.804688);
            cr.LineTo(109.046875, 316.46875);
            cr.CurveTo(108.550781, 324.011719, 114.328125, 330.179688, 121.886719, 330.179688);
            cr.LineTo(208.292969, 330.179688);
            cr.CurveTo(215.851563, 330.179688, 221.628906, 324.011719, 221.132813, 316.46875);
            cr.ClosePath();
            cr.MoveTo(206.988281, 194.84375);
            cr.FillPreserve();
        }
    }
}