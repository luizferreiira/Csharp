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
    public partial class DicaContinuacao2 : Form
    {
        public DicaContinuacao2()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            DicaContinuacao dica2 = new DicaContinuacao();
            this.Hide();
            dica2.Show();
        }

        private void btn_IrExercicio_Click(object sender, EventArgs e)
        {
            Exercicio exercicio = new Exercicio();
            this.Hide();
            exercicio.Show();
        }
    }
}
