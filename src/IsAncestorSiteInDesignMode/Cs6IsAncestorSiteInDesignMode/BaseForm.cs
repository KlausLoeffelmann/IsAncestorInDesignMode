using System.Diagnostics;

namespace Cs6IsAncestorSiteInDesignMode
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            // THIS WILL FAIL!
            // The Form can never be sited in the constructor.
            // So we cannot detect, if it will be in Design Mode.
            // Also, we cannot detect if its Ancestors are in DesignMode
            // at this point, since it doesn't have a parent control here:
            var testForDesignMode = IsAncestorSiteInDesignMode;
            Debug.Print($"testForDesignMode will always be {testForDesignMode}.");
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();

            // IMPORTANT:
            // This will fail, if this Form is opened directly in the Designer.
            // The reason: We NEVER design the defined type. We only design 
            // the type this Form derives from, and then we populate the controls
            // per the Form's definition. At design time, the Form type's does not exist!
            // This works, because MainForm is derived from this Form. So, 
            // MainForm will show the correct state for the DesignMode (of _this_ (base) form).
            _designModeToolStripStatusLabe.Text = $"Is Design mode: {this.DesignMode}";
        }
    }
}
