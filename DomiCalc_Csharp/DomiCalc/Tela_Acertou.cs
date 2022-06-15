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
    public partial class Tela_Acertou : Form
    {
        public Tela_Acertou()
        {
            InitializeComponent();
        }

        private void BTN_continuar_Click(object sender, EventArgs e)
        {
            Fases fases = new Fases();
            this.Hide();
            fases.Show();
        }
    }
}
