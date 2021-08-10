using System.Diagnostics;

namespace Cs6IsAncestorSiteInDesignMode
{
    public class MyControl : Panel
    {
        private string? _statusText;
        private TextContentRenderer? _renderer;

        public MyControl()
        {
            // We're painting, so let's paint without flicker!
            DoubleBuffered = true;
            ResizeRedraw = true;

            // THIS WILL FAIL!
            // The Control can never be sited in the constructor.
            // So we cannot detect, if it will be in Design Mode.
            // Also, we cannot detect if its Ancestors are in DesignMode
            // at this point, since it doesn't have a parent control here:
            var testForDesignMode = IsAncestorSiteInDesignMode;
            Debug.Print($"testForDesignMode will always be {testForDesignMode}.");
        }

        protected override void CreateHandle()
        {
            // IMPORTANT! Never forget to call the base method here!!!
            base.CreateHandle();

            _statusText = $"This MyControl instance {(IsAncestorSiteInDesignMode ? "is" : "is not")} considered to be in Design Mode.";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            _renderer = new TextContentRenderer(_statusText!, Font, Brushes.Black);

            _renderer.Render(
                e.Graphics,
                ClientRectangle,
                TextContentRenderer.RenderParts.Center |
                TextContentRenderer.RenderParts.ShowBorder);
        }
    }
}
