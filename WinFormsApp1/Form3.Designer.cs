namespace WinFormsApp1
{
    partial class Form3
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
            kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            kryptonRibbonTab2 = new Krypton.Ribbon.KryptonRibbonTab();
            kryptonRibbonTab3 = new Krypton.Ribbon.KryptonRibbonTab();
            ((System.ComponentModel.ISupportInitialize)kryptonRibbon1).BeginInit();
            SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            kryptonRibbon1.Name = "kryptonRibbon1";
            kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] { kryptonRibbonTab1, kryptonRibbonTab2, kryptonRibbonTab3 });
            kryptonRibbon1.SelectedTab = kryptonRibbonTab1;
            kryptonRibbon1.Size = new Size(823, 136);
            kryptonRibbon1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 443);
            CloseBox = false;
            Controls.Add(kryptonRibbon1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)kryptonRibbon1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;
    }
}