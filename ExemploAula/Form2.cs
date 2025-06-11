using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploAula
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btnvoltarlogin_Click(object sender, EventArgs e)
        {
            Hide();
            frmlogin login= new frmlogin();
            login.Show();
        }
    }
}
