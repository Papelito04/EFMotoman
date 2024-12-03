namespace MMForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        Helpers helper = new Helpers();
        private async void btnPersonas_Click(object sender, EventArgs e)
        {
            await helper.GetAllInventarios();

            
            dgvPrueba.DataSource = helper.RetornarInventarios();
        }
    }
}
