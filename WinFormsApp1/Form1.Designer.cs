namespace WinFormsApp1
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            checkBox1 = new CheckBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            kryptonIntegratedToolBarManager1 = new Krypton.Toolkit.KryptonIntegratedToolBarManager();
            kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(623, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Todos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(600, 80);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6 });
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(682, 197);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 30;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "DNI";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 80;
            // 
            // Column3
            // 
            Column3.HeaderText = "TRABAJADOR";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 300;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.HeaderText = "CELULAR";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "ESTADO";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipo Trabjador :";
            // 
            // button2
            // 
            button2.Location = new Point(500, 80);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Empleado", "Operario", "Practicante" });
            comboBox1.Location = new Point(138, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 28);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 70);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha Ingreso :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(138, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Location = new Point(46, 338);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(150, 120);
            kryptonListBox1.TabIndex = 8;
            // 
            // kryptonIntegratedToolBarManager1
            // 
            kryptonIntegratedToolBarManager1.IntegratedToolBarButtonAlignment = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            kryptonIntegratedToolBarManager1.IntegratedToolBarButtonOrientation = Krypton.Toolkit.PaletteButtonOrientation.FixedTop;
            // 
            // kryptonGroup1
            // 
            kryptonGroup1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            kryptonGroup1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonBreadCrumb;
            kryptonGroup1.Location = new Point(239, 346);
            kryptonGroup1.Size = new Size(364, 125);
            kryptonGroup1.StateCommon.Border.Rounding = 20F;
            kryptonGroup1.TabIndex = 9;
            // 
            // kryptonGroupBox1
            // 
            kryptonGroupBox1.Location = new Point(623, 338);
            kryptonGroupBox1.Size = new Size(188, 133);
            kryptonGroupBox1.TabIndex = 10;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.ButtonSpecs.Add(buttonSpecAny1);
            kryptonComboBox1.DropDownWidth = 316;
            kryptonComboBox1.Items.AddRange(new object[] { "PERU", "BRASIL", "PANAMA", "ARGENTINA", "URUGUAY" });
            kryptonComboBox1.Location = new Point(82, 496);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(327, 26);
            kryptonComboBox1.TabIndex = 11;
            // 
            // buttonSpecAny1
            // 
            buttonSpecAny1.UniqueName = "5b91120e22fd42ffb444e8890c0c8d74";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 549);
            Controls.Add(kryptonComboBox1);
            Controls.Add(kryptonGroupBox1);
            Controls.Add(kryptonGroup1);
            Controls.Add(kryptonListBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewCheckBoxColumn Column6;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonIntegratedToolBarManager kryptonIntegratedToolBarManager1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}
