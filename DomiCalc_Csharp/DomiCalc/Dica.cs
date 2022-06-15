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
    public partial class Dica : Form
    {
        public Dica()
        {
            InitializeComponent();
        }

        private void LBL_parabens_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Fases fases = new Fases();
            this.Hide();
            fases.Show();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            DicaContinuacao dicaC = new DicaContinuacao();
            this.Hide();
            dicaC.Show();
        }
    }
}
