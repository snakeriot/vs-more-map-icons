using Cairo;

namespace MoreMapIcons
{
    /**
     * Castle Ruin icon.
     **/
    public class CastleRuinIcon : Icon
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
        * It was my castle.
        *
        * @param context - {@link Context}
        **/
        public void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(382.976563, 17.699219);
            cr.LineTo(306.679688, 119.429688);
            cr.LineTo(459.269531, 93.996094);
            cr.LineTo(382.972656, 17.699219);
            cr.ClosePath();
            cr.MoveTo(106.238281, 77.894531);
            cr.LineTo(88.738281, 82.105469);
            cr.LineTo(122.789063, 223.59375);
            cr.LineTo(136.390625, 203.1875);
            cr.ClosePath();
            cr.MoveTo(71.03125, 85.578125);
            cr.CurveTo(62.179688, 127.035156, 53.304688, 175.644531, 29.628906, 196.707031);
            cr.CurveTo(38.65625, 199.058594, 51.046875, 195.511719, 64.28125, 172.996094);
            cr.CurveTo(71.230469, 188.960938, 66.59375, 190.460938, 62.324219, 201.734375);
            cr.CurveTo(78.886719, 198.304688, 87.527344, 183.203125, 87.195313, 163.929688);
            cr.ClosePath();
            cr.MoveTo(437.988281, 115.792969);
            cr.LineTo(361, 128.621094);
            cr.LineTo(361, 160);
            cr.LineTo(343, 160);
            cr.LineTo(343, 131.621094);
            cr.LineTo(311, 136.957031);
            cr.LineTo(311, 199);
            cr.LineTo(393, 199);
            cr.LineTo(393, 231);
            cr.LineTo(423, 231);
            cr.LineTo(423, 199);
            cr.LineTo(438.847656, 199);
            cr.LineTo(420.070313, 142.671875);
            cr.ClosePath();
            cr.MoveTo(148.816406, 217);
            cr.LineTo(117.777344, 263.5625);
            cr.LineTo(76.691406, 277.257813);
            cr.LineTo(108.691406, 341.257813);
            cr.LineTo(52.859375, 359.867188);
            cr.LineTo(25, 387.726563);
            cr.LineTo(25, 487);
            cr.LineTo(115.511719, 487);
            cr.LineTo(104.4375, 453.773438);
            cr.LineTo(59.007813, 423.488281);
            cr.LineTo(68.992188, 408.511719);
            cr.LineTo(119.5625, 442.226563);
            cr.LineTo(134.488281, 487);
            cr.LineTo(282.4375, 487);
            cr.LineTo(310.28125, 431.308594);
            cr.LineTo(296.886719, 391.113281);
            cr.LineTo(208, 361.488281);
            cr.LineTo(162.847656, 376.539063);
            cr.LineTo(157.152344, 359.460938);
            cr.LineTo(201.195313, 344.78125);
            cr.LineTo(229.4375, 274.167969);
            cr.LineTo(204.273438, 249);
            cr.LineTo(151, 249);
            cr.LineTo(151, 217);
            cr.ClosePath();
            cr.MoveTo(217, 217);
            cr.LineTo(217, 236.273438);
            cr.LineTo(245.328125, 264.601563);
            cr.LineTo(308.023438, 295.949219);
            cr.LineTo(299.976563, 312.050781);
            cr.LineTo(244.722656, 284.425781);
            cr.LineTo(219.902344, 346.480469);
            cr.LineTo(311.113281, 376.886719);
            cr.LineTo(327.867188, 427.140625);
            cr.LineTo(359.398438, 458.667969);
            cr.LineTo(373.5625, 487);
            cr.LineTo(487, 487);
            cr.LineTo(487, 336.816406);
            cr.LineTo(452.523438, 359.800781);
            cr.LineTo(420.023438, 376.050781);
            cr.LineTo(411.976563, 359.949219);
            cr.LineTo(443.476563, 344.203125);
            cr.LineTo(487, 315.183594);
            cr.LineTo(487, 217);
            cr.LineTo(441, 217);
            cr.LineTo(441, 249);
            cr.LineTo(375, 249);
            cr.LineTo(375, 217);
            cr.LineTo(329, 217);
            cr.LineTo(329, 249);
            cr.LineTo(263, 249);
            cr.LineTo(263, 217);
            cr.ClosePath();
            cr.FillPreserve();
        }
    }
}