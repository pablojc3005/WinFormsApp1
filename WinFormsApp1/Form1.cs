namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LlenarDataGridView()
        {
            // Limpia las filas existentes
            dataGridView1.Rows.Clear();

            // Agrega filas manualmente
            dataGridView1.Rows.Add(1, "12345678", "Juan pablo dias", "9123525487", true);
            dataGridView1.Rows.Add(2, "12345678", "pablo corzo sedano", "9123525487", true);
            dataGridView1.Rows.Add(3, "12345678", "maria delgado perez", "9123525487", true);
            dataGridView1.Rows.Add(4, "12345678", "anibal quinteros matta", "9123525487", true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.ShowDialog();
        }
    }
}
