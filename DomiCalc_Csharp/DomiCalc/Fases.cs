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
    public partial class Fases : Form
    {
        public Fases()
        {
            InitializeComponent();
        }


        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Tela_Jogar jogar = new Tela_Jogar();
            this.Hide();
            jogar.Show();
        }

        private void btn_Nivel1_Click(object sender, EventArgs e)
        {
            Dica dica = new Dica();
            this.Hide();
            dica.Show();
        }
    }
}
