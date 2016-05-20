using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CRM01
{
    public partial class frmCRM01 : Form
    {
        public frmCRM01()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Evento para manipular banco de dados***Testando atualização GitHub
            try
            {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into CRM01(nome, endereco, complemento, nascimento, telefone, email) values(@nome, @endereco, @complemento, @nascimento, @telefone, @email)";
            command.Parameters.AddWithValue("nome", txbNome.Text);
            command.Parameters.AddWithValue("endereco", txbEndereco.Text);
            command.Parameters.AddWithValue("complemento", txbComplemento.Text);
            command.Parameters.AddWithValue("nascimento", txbNascimento.Text);
            command.Parameters.AddWithValue("telefone", txbTelefone.Text);
            command.Parameters.AddWithValue("email", txbEmail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Relacionamento registrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
