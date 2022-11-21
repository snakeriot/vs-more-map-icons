using Cairo;
using System;

namespace MoreMapIcons
{
    /**
     * Service that renders icon, is needed to encapsulate all boilerplate code which perpares icon for rendering.
     **/
    public class IconRenderService
    {
        /**
        * Service that renders icon, is needed to encapsulate all boilerplate code which perpares icon for rendering.
        * 
        * @param icon - {@link Icon}
        * @param ctx - {@link Context}
        * @param x - float, x position of an icon
        * @param y - float, y position of an icon
        * @param w - float, width of an icon to render
        * @param h - float, height of an icon to render
        * @param rgba - double[], array which describes color and alpha chanel of the icon
        **/
        public void Render(Icon icon, Context ctx, float x, float y, float w, float h, double[] rgba)
        {
            Pattern pattern = InitializeContext(icon, ctx, x, y, w, h, rgba);
            icon.Render(ctx);
            DisposeContext(ctx, pattern);
        }

        private Pattern InitializeContext(Icon icon, Context ctx, float x, float y, float w, float h, double[] rgba)
        {
            ctx.SetSourceRGBA(rgba);
            Pattern pattern = null;
            Matrix matrix = ctx.Matrix;

            ctx.Save();
            float width = icon.getWidth();
            float height = icon.getHeight();
            float scale = Math.Min(w / width, h / height);
            matrix.Translate(x + Math.Max(0, (w - width * scale) / 2), y + Math.Max(0, (h - height * scale) / 2));
            matrix.Scale(scale, scale);
            ctx.Matrix = matrix;
            ctx.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            ctx.SetSource(pattern);
            return pattern;
        }

        private void DisposeContext(Context ctx, Pattern pattern)
        {
            ctx.Tolerance = 0.1;
            ctx.Antialias = Antialias.Default;
            ctx.FillRule = FillRule.Winding;
            ctx.FillPreserve();
            if (pattern != null) pattern.Dispose();
            ctx.Restore();
        }
    }
}