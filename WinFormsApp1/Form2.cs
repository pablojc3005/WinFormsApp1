using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LlenarDataGridView()
        {
            // Limpia las filas existentes
            dgvlista.Rows.Clear();

            // Agrega filas manualmente
            dgvlista.Rows.Add(1, "12345678", "Juan pablo dias", "9123525487", true);
            dgvlista.Rows.Add(2, "12345678", "pablo corzo sedano", "9123525487", true);
            dgvlista.Rows.Add(3, "12345678", "maria delgado perez", "9123525487", true);
            dgvlista.Rows.Add(4, "12345678", "anibal quinteros matta", "9123525487", true);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.ShowDialog();
        }
    }
}
