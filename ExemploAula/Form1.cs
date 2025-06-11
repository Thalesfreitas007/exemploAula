namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
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
