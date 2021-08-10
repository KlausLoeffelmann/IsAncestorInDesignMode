namespace Cs6IsAncestorSiteInDesignMode
{
    public partial class MyUserControl : UserControl
    {
        private string? _statusText;
        private TextContentRenderer? _renderer;

        public MyUserControl()
        {
            InitializeComponent();
        }
        protected override void CreateHandle()
        {
            // IMPORTANT! Never forget to call the base method here!!!
            base.CreateHandle();

            _statusText = $"This MyUserControl instance {(IsAncestorSiteInDesignMode ? "is" : "is not")} considered to be in Design Mode.";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _renderer = new TextContentRenderer(_statusText!, Font, Brushes.Black);
            _renderer.Render(
                e.Graphics,
                ClientRectangle,
                TextContentRenderer.RenderModes.UpperLeft |
                TextContentRenderer.RenderModes.LowerRight |
                TextContentRenderer.RenderModes.ShowBorder);
        }
    }
}
