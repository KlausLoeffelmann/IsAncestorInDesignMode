
namespace Cs6IsAncestorSiteInDesignMode
{
    partial class MyUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myControl1 = new Cs6IsAncestorSiteInDesignMode.MyControl();
            this.SuspendLayout();
            // 
            // myControl1
            // 
            this.myControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myControl1.Location = new System.Drawing.Point(149, 149);
            this.myControl1.Name = "myControl1";
            this.myControl1.Size = new System.Drawing.Size(717, 432);
            this.myControl1.TabIndex = 4;
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myControl1);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(1015, 730);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl myControl1;
    }
}
