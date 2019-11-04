using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalicacao4
{
    public partial class Form1 : Form
    {
        /*
         * TODO
         * * SQL-> Crie 2 tabelas (Produto e Categoria). O produto obrigatóriamente deverá ter uma categoria.
	        Popule via instrução INSERT essas tabelas com no mínimo 5 produtos e 3 categorias. (Salve o script no diretório raiz da solution)
	        * (Essa solution já está conecta ao banco)
	        * Desenvolva o método que mostre o produto e sua categoria em um GridView.
         */

        const string strcon = "Data Source=DBD2OPR;User ID=accesscontrol;Password=accesscontrol";
        OracleConnection _conexao;
        public Form1()
        {
            InitializeComponent();
            ConexaoDB();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            OracleDataAdapter cmd = new OracleDataAdapter("select * from PRODUTO1", _conexao);
            try
            {
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conexao.Close();
            }
        }

        private void ConexaoDB()
        {
            _conexao = new OracleConnection
            {
                ConnectionString = strcon
            };
            _conexao.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
