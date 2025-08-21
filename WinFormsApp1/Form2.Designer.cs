namespace WinFormsApp1
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dateTimePicker2 = new DateTimePicker();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonRadioButton2 = new Krypton.Toolkit.KryptonRadioButton();
            kryptonRadioButton1 = new Krypton.Toolkit.KryptonRadioButton();
            dgvlista = new Krypton.Toolkit.KryptonDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvlista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(348, 49);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(132, 27);
            dateTimePicker2.TabIndex = 37;
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new Point(611, 375);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new Size(69, 24);
            kryptonCheckBox1.TabIndex = 36;
            kryptonCheckBox1.Values.Text = "Todos";
            // 
            // kryptonNumericUpDown1
            // 
            kryptonNumericUpDown1.AllowDecimals = true;
            kryptonNumericUpDown1.DecimalPlaces = 2;
            kryptonNumericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            kryptonNumericUpDown1.Location = new Point(491, 375);
            kryptonNumericUpDown1.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            kryptonNumericUpDown1.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            kryptonNumericUpDown1.Size = new Size(114, 26);
            kryptonNumericUpDown1.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonNumericUpDown1.TabIndex = 35;
            kryptonNumericUpDown1.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(133, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(632, 88);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(139, 37);
            kryptonButton2.StateCommon.Border.Rounding = 20F;
            kryptonButton2.TabIndex = 33;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Guardar";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(491, 88);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(135, 37);
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.TabIndex = 32;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Nuevo";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(75, 17);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(52, 24);
            kryptonLabel5.TabIndex = 31;
            kryptonLabel5.Values.Text = "Sexo :";
            // 
            // kryptonRadioButton2
            // 
            kryptonRadioButton2.Location = new Point(248, 17);
            kryptonRadioButton2.Name = "kryptonRadioButton2";
            kryptonRadioButton2.Size = new Size(94, 24);
            kryptonRadioButton2.TabIndex = 30;
            kryptonRadioButton2.Values.Text = "Femenino";
            // 
            // kryptonRadioButton1
            // 
            kryptonRadioButton1.Location = new Point(133, 17);
            kryptonRadioButton1.Name = "kryptonRadioButton1";
            kryptonRadioButton1.Size = new Size(96, 24);
            kryptonRadioButton1.TabIndex = 29;
            kryptonRadioButton1.Values.Text = "Masculino";
            // 
            // dgvlista
            // 
            dgvlista.AllowUserToAddRows = false;
            dgvlista.AllowUserToDeleteRows = false;
            dgvlista.BorderStyle = BorderStyle.None;
            dgvlista.ColumnHeadersHeight = 25;
            dgvlista.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvlista.Location = new Point(16, 139);
            dgvlista.Name = "dgvlista";
            dgvlista.RowHeadersVisible = false;
            dgvlista.RowHeadersWidth = 51;
            dgvlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlista.Size = new Size(786, 225);
            dgvlista.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvlista.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvlista.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvlista.TabIndex = 28;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 40;
            // 
            // Column2
            // 
            Column2.HeaderText = "DNI";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 85;
            // 
            // Column3
            // 
            Column3.HeaderText = "TRABAJADOR";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 400;
            // 
            // Column4
            // 
            Column4.HeaderText = "CELULAR";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = false;
            Column5.DefaultCellStyle = dataGridViewCellStyle4;
            Column5.FalseValue = null;
            Column5.HeaderText = "ESTADO";
            Column5.IndeterminateValue = null;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.TrueValue = null;
            Column5.Width = 75;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(559, 17);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(46, 24);
            kryptonLabel4.TabIndex = 27;
            kryptonLabel4.Values.Text = "Pais :";
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownWidth = 170;
            kryptonComboBox1.Items.AddRange(new object[] { "PERU", "BRAZIL", "ALEMANIA", "FRANCIA", "ECUADOR" });
            kryptonComboBox1.Location = new Point(611, 17);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(191, 26);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 26;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(284, 52);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(58, 24);
            kryptonLabel3.TabIndex = 25;
            kryptonLabel3.Values.Text = "Hasta :";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(35, 95);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(92, 24);
            kryptonLabel2.TabIndex = 24;
            kryptonLabel2.Values.Text = "Trabajador :";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(65, 52);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(62, 24);
            kryptonLabel1.TabIndex = 23;
            kryptonLabel1.Values.Text = "Desde :";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(133, 92);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(347, 33);
            kryptonTextBox1.StateCommon.Border.Rounding = 10F;
            kryptonTextBox1.TabIndex = 38;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 417);
            Controls.Add(kryptonTextBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(kryptonCheckBox1);
            Controls.Add(kryptonNumericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonRadioButton2);
            Controls.Add(kryptonRadioButton1);
            Controls.Add(dgvlista);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonComboBox1);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StateCommon.Border.Rounding = 10F;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvlista).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker2;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonRadioButton kryptonRadioButton2;
        private Krypton.Toolkit.KryptonRadioButton kryptonRadioButton1;
        private Krypton.Toolkit.KryptonDataGridView dgvlista;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn Column5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}