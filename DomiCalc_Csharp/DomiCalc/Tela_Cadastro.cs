using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DomiCalc
{
    public partial class Tela_Cadastro : Form
    {


        public Tela_Cadastro()
        {
            InitializeComponent();
            txtNome.Select();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
            txtNome.Text = null;
            txtSenha.Text = null;
            txtEmail.Text = null;
            txtTelefone.Text = null;
            txtNome.Select();
        }


        private void CadastrarUsuario()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(@"Data Source = TIGAS\MSQLEXPRESS;Initial Catalog = DomiCalcDB; Integrated Security = True");
                {
                    conexao.Open();

                    var sql = "INSERT INTO Usuario (Nome, Senha, Email, Telefone) VALUES (@Nome, @Senha, @Email, @Telefone)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                       

                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro realizado com sucesso!!\n\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!\n\n" + ex.Message);
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Tela_Inicial inicial = new Tela_Inicial();
            this.Hide();
            inicial.Show();
        }
    }
}
