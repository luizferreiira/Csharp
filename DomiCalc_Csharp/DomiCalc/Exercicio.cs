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
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
            txtResposta.Select();
        }

        private void btn_VoltarFases_Click(object sender, EventArgs e)
        {
            Fases fases = new Fases();
            this.Hide();
            fases.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DicaContinuacao dicaC = new DicaContinuacao();
            this.Hide();
            dicaC.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DicaContinuacao dicaC = new DicaContinuacao();
            this.Hide();
            dicaC.Show();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txtResposta.Text == "50")
            {
                Tela_Acertou acertou = new Tela_Acertou();
                this.Hide();
                acertou.Show();
            }
            else
            {
                Tela_TentarDNV tentarDNV = new Tela_TentarDNV();
                this.Hide();
                tentarDNV.Show();
            }
        }
    }
}
