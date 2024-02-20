namespace CadastroPDS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroE em = new CadastroE();
            em.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
