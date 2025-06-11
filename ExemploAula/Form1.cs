namespace ExemploAula
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text=="admin"&& txtsenha.Text=="123456")
            {
                MessageBox.Show("login realizado com sucesso");
                txtusuario.Clear();
                txtsenha.Clear();
                txtusuario.Focus();
                Hide();
                frmmenu menu = new frmmenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("usuário ou senha errados");
                txtusuario.Clear();
                txtsenha.Clear();
                txtusuario.Focus();
            }
        }
    }
}
