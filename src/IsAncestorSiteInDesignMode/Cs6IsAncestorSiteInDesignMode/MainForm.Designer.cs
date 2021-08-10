
namespace Cs6IsAncestorSiteInDesignMode
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myUserControl1 = new Cs6IsAncestorSiteInDesignMode.MyUserControl();
            this.myControl1 = new Cs6IsAncestorSiteInDesignMode.MyControl();
            this.SuspendLayout();
            // 
            // myUserControl1
            // 
            this.myUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myUserControl1.Location = new System.Drawing.Point(40, 42);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(890, 555);
            this.myUserControl1.TabIndex = 2;
            // 
            // myControl1
            // 
            this.myControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myControl1.Location = new System.Drawing.Point(124, 106);
            this.myControl1.Name = "myControl1";
            this.myControl1.Size = new System.Drawing.Size(717, 432);
            this.myControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 663);
            this.Controls.Add(this.myControl1);
            this.Controls.Add(this.myUserControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.myUserControl1, 0);
            this.Controls.SetChildIndex(this.myControl1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyUserControl myUserControl1;
        private MyControl myControl1;
    }
}

