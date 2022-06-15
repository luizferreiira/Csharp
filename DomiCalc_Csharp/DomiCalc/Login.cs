using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomiCalc
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            txtEmail.Select();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIrCadastro_Click(object sender, EventArgs e)
        {
            Tela_Cadastro cadastro = new Tela_Cadastro();
            this.Hide();
            cadastro.Show();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source = TIGAS\MSQLEXPRESS; Initial Catalog = DomiCalcDB; Integrated Security = True");
            conexao.Open();

            string query = "SELECT * FROM Usuario WHERE Email = '" + txtEmail.Text + "' AND Senha = '" + txtSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                Tela_Jogar jogar = new Tela_Jogar();
                this.Hide();
                jogar.Show();
                conexao.Close();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválido(a)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = null;
                txtSenha.Text = null;
                txtEmail.Select();
            }

        }

    }
}
