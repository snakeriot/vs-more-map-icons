using Cairo;

namespace MoreMapIcons
{
    /**
     * Skull icon.
     **/
    public class SkullIcon : Icon
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
        * Draw my skull (nope, not mine!).
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(251.09375, 0.0507813);
            cr.CurveTo(121.207031, 2.652344, 16.550781, 109.664063, 16.695313, 239.574219);
            cr.CurveTo(16.777344, 314.648438, 51.5625, 381.449219, 105.738281, 425.242188);
            cr.LineTo(105.738281, 495.304688);
            cr.CurveTo(105.738281, 504.523438, 113.214844, 512, 122.433594, 512);
            cr.LineTo(155.824219, 512);
            cr.CurveTo(165.046875, 512, 172.523438, 504.527344, 172.523438, 495.304688);
            cr.LineTo(172.523438, 462.386719);
            cr.CurveTo(172.523438, 453.394531, 179.429688, 445.660156, 188.410156, 445.238281);
            cr.CurveTo(198, 444.785156, 205.914063, 452.425781, 205.914063, 461.914063);
            cr.LineTo(205.914063, 495.304688);
            cr.CurveTo(205.914063, 504.523438, 213.390625, 512, 222.609375, 512);
            cr.CurveTo(231.832031, 512, 239.304688, 504.527344, 239.304688, 495.304688);
            cr.LineTo(239.304688, 462.386719);
            cr.CurveTo(239.304688, 453.394531, 246.214844, 445.660156, 255.195313, 445.238281);
            cr.CurveTo(264.78125, 444.785156, 272.699219, 452.425781, 272.699219, 461.914063);
            cr.LineTo(272.699219, 495.304688);
            cr.CurveTo(272.699219, 504.523438, 280.171875, 512, 289.394531, 512);
            cr.CurveTo(298.613281, 512, 306.089844, 504.527344, 306.089844, 495.304688);
            cr.LineTo(306.089844, 462.386719);
            cr.CurveTo(306.089844, 453.394531, 313, 445.660156, 321.980469, 445.238281);
            cr.CurveTo(331.566406, 444.785156, 339.480469, 452.425781, 339.480469, 461.914063);
            cr.LineTo(339.480469, 495.304688);
            cr.CurveTo(339.480469, 504.523438, 346.957031, 512, 356.179688, 512);
            cr.LineTo(389.570313, 512);
            cr.CurveTo(398.789063, 512, 406.265625, 504.527344, 406.265625, 495.304688);
            cr.LineTo(406.265625, 425.242188);
            cr.CurveTo(460.507813, 381.398438, 495.308594, 314.488281, 495.308594, 239.304688);
            cr.CurveTo(495.304688, 105.507813, 385.503906, -2.644531, 251.09375, 0.0507813);
            cr.ClosePath();
            cr.MoveTo(150.261719, 322.78125);
            cr.CurveTo(113.378906, 322.78125, 83.476563, 292.882813, 83.476563, 256);
            cr.CurveTo(83.476563, 219.117188, 113.378906, 189.21875, 150.261719, 189.21875);
            cr.CurveTo(187.144531, 189.21875, 217.042969, 219.117188, 217.042969, 256);
            cr.CurveTo(217.042969, 292.882813, 187.144531, 322.78125, 150.261719, 322.78125);
            cr.ClosePath();
            cr.MoveTo(301.195313, 384.675781);
            cr.CurveTo(297.933594, 387.933594, 293.660156, 389.566406, 289.390625, 389.566406);
            cr.CurveTo(285.117188, 389.566406, 280.847656, 387.933594, 277.585938, 384.675781);
            cr.LineTo(256, 363.085938);
            cr.LineTo(234.414063, 384.675781);
            cr.CurveTo(227.890625, 391.195313, 217.324219, 391.195313, 210.804688, 384.675781);
            cr.CurveTo(204.28125, 378.152344, 204.28125, 367.585938, 210.804688, 361.066406);
            cr.LineTo(244.195313, 327.675781);
            cr.CurveTo(250.714844, 321.152344, 261.28125, 321.152344, 267.804688, 327.675781);
            cr.LineTo(301.195313, 361.066406);
            cr.CurveTo(307.71875, 367.585938, 307.71875, 378.152344, 301.195313, 384.675781);
            cr.ClosePath();
            cr.MoveTo(361.738281, 322.78125);
            cr.CurveTo(324.855469, 322.78125, 294.957031, 292.882813, 294.957031, 256);
            cr.CurveTo(294.957031, 219.117188, 324.855469, 189.21875, 361.738281, 189.21875);
            cr.CurveTo(398.621094, 189.21875, 428.523438, 219.117188, 428.523438, 256);
            cr.CurveTo(428.523438, 292.882813, 398.621094, 322.78125, 361.738281, 322.78125);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}