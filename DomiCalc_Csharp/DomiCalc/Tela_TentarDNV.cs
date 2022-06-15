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
    public partial class Tela_TentarDNV : Form
    {
        public Tela_TentarDNV()
        {
            InitializeComponent();
        }


        private void BTN_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_tentar_Click(object sender, EventArgs e)
        {
            Exercicio ex = new Exercicio();
            this.Hide();
            ex.Show();
        }

    }
}
