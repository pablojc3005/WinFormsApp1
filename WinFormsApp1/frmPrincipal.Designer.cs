namespace WinFormsApp1
{
    partial class frmPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            kryptonRibbonGroup3 = new Krypton.Ribbon.KryptonRibbonGroup();
            kryptonRibbonGroup4 = new Krypton.Ribbon.KryptonRibbonGroup();
            ((System.ComponentModel.ISupportInitialize)kryptonRibbon1).BeginInit();
            SuspendLayout();
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Dock = DockStyle.Bottom;
            kryptonToolStrip1.Font = new Font("Segoe UI", 9F);
            kryptonToolStrip1.ImageScalingSize = new Size(20, 20);
            kryptonToolStrip1.Location = new Point(0, 411);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new Size(804, 25);
            kryptonToolStrip1.TabIndex = 0;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // kryptonRibbon1
            // 
            kryptonRibbon1.Name = "kryptonRibbon1";
            kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] { kryptonRibbonTab1 });
            kryptonRibbon1.SelectedTab = kryptonRibbonTab1;
            kryptonRibbon1.Size = new Size(804, 171);
            kryptonRibbon1.TabIndex = 1;
            // 
            // kryptonRibbonTab1
            // 
            kryptonRibbonTab1.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] { kryptonRibbonGroup1, kryptonRibbonGroup2, kryptonRibbonGroup3, kryptonRibbonGroup4 });
            // 
            // kryptonRibbonGroup1
            // 
            kryptonRibbonGroup1.MaximumWidth = 250;
            kryptonRibbonGroup1.MinimumWidth = 100;
            kryptonRibbonGroup1.TextLine1 = "Trabajador";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 436);
            Controls.Add(kryptonRibbon1);
            Controls.Add(kryptonToolStrip1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)kryptonRibbon1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
    }
}