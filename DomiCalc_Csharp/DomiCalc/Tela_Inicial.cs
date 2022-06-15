using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomiCalc
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void txtComecar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro telaCadastro = new Tela_Cadastro();
            this.Hide();
            telaCadastro.Show();
        }

        private void txt_JaTenho_Click(object sender, EventArgs e)
        {
            Login login = new DomiCalc.Login();
            this.Hide();
            login.Show();
        }
    }
}
