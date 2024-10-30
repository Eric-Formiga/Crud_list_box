namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            carsListBox.Items.Add(txtNomeModelo.Text);
            txtNomeModelo.Clear();
            txtNomeModelo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = carsListBox.Items.Count;
            qtdItens.Text = count.ToString();
            qtdItens.Visible = true;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            carsListBox.Sorted = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            object? selectedItem = carsListBox.SelectedItem;

            if (selectedItem != null)
            {
                carsListBox.Items.Remove(selectedItem);
            }
        }

        private void qtdItens_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            carsListBox.Items.Clear();
        }
    }
}
