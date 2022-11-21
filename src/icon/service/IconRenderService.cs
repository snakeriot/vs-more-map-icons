using Cairo;
using System;

namespace MoreMapIcons
{
    public class IconRenderService
    {

        public void Render(Icon icon, Context ctx, float x, float y, float w, float h, double[] rgba)
        {
            Pattern pattern = InitializeContext(ctx, x, y, w, h, rgba);
            icon.Render(ctx);
            DisposeContext(ctx, pattern);
        }

        private Pattern InitializeContext(Context ctx, float x, float y, float w, float h, double[] rgba)
        {
            ctx.SetSourceRGBA(rgba);
            Pattern pattern = null;
            Matrix matrix = ctx.Matrix;

            ctx.Save();
            float width = 400;
            float height = 400;
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