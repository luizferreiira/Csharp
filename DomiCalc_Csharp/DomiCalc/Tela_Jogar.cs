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
    public partial class Tela_Jogar : Form
    {
        public Tela_Jogar()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            Fases fases = new Fases();
            this.Hide();
            fases.Show();
        }

        private void btn_VideoAula_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.youtube.com/c/ProfessorMarceloSilv%C3%A9rioMatem%C3%A1tica");
        }

        private void AbrirLink(string endereco)
        {
            System.Diagnostics.Process.Start(endereco);
        }
    }
}
