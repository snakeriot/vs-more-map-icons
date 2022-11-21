using Cairo;

namespace MoreMapIcons
{
    public class MushroomIcon : Icon
    {
        public override void Render(Context cr)
        {
            cr.NewPath();
            cr.MoveTo(20, 20);
            cr.LineTo(380, 20);
            cr.LineTo(200, 380);
            cr.LineTo(20, 20);
            cr.ClosePath();
        }
    }
}