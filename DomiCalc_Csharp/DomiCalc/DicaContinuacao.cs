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
    public partial class DicaContinuacao : Form
    {
        public DicaContinuacao()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Dica dica = new Dica();
            this.Hide();
            dica.Show();
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            DicaContinuacao2 dica2 = new DicaContinuacao2();
            this.Hide();
            dica2.Show();
        }
    }
}
