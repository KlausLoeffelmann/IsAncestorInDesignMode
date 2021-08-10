namespace Cs6IsAncestorSiteInDesignMode
{
    public class TextContentRenderer
    {
        private readonly string _text;
        private readonly Font _font;
        private readonly Brush _brush;

        public TextContentRenderer(string text, Font font, Brush brush)
        {
            _text = text;
            _font = font;
            _brush = brush;
        }

        public void Render(Graphics g, Rectangle bounds, RenderParts renderParts)
        {
            var textBounds = g.MeasureString(_text, _font);

            if (renderParts.HasFlag(RenderParts.Center))
            {
                g.DrawString(_text, _font, _brush,
                    bounds.X + bounds.Width / 2 - textBounds.Width / 2,
                    bounds.Y + bounds.Height / 2 - textBounds.Height / 2);
            }

            if (renderParts.HasFlag(RenderParts.UpperLeft))
            {
                g.DrawString(_text, _font, _brush,
                    bounds.X,
                    bounds.Y);
            }

            if (renderParts.HasFlag(RenderParts.LowerLeft))
            {
                g.DrawString(_text, _font, _brush,
                    bounds.X,
                    bounds.Y + bounds.Height - textBounds.Height);
            }

            if (renderParts.HasFlag(RenderParts.UpperRight))
            {
                g.DrawString(_text, _font, _brush,
                    bounds.X + bounds.Width - textBounds.Width,
                    bounds.Y);
            }

            if (renderParts.HasFlag(RenderParts.LowerRight))
            {
                g.DrawString(_text, _font, _brush,
                    bounds.X + bounds.Width - textBounds.Width,
                    bounds.Y + bounds.Height - textBounds.Height);
            }

            if (renderParts.HasFlag(RenderParts.LowerRight))
            {
                g.DrawString(_text, _font, _brush,
                    bounds.X + bounds.Width - textBounds.Width,
                    bounds.Y + bounds.Height - textBounds.Height);
            }

            if (renderParts.HasFlag(RenderParts.ShowBorder))
            {
                g.DrawRectangle(Pens.Black, Rectangle.Inflate(bounds, -1, -1));
            }
        }

        public enum RenderParts
        {
            Center = 1,
            UpperLeft = 2,
            UpperRight = 4,
            LowerLeft = 8,
            LowerRight = 16,
            AllEdges = UpperLeft | UpperRight | LowerLeft | LowerRight,
            EveryWhere = AllEdges | Center,
            ShowBorder = 32
        }
    }
}
