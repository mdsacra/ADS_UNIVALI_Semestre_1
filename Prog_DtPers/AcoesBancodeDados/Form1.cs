using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder criaConexaoBD = new MySqlConnectionStringBuilder();

            criaConexaoBD.Server = "localhost";
            criaConexaoBD.Database = "visualstudio";
            criaConexaoBD.UserID = "root";
            criaConexaoBD.Password = "";

            MySqlConnection realizaConexaoBD = new MySqlConnection(criaConexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand cmd = realizaConexaoBD.CreateCommand();
                cmd.CommandText = "INSERT INTO cadastro (nome) VALUE ('"
                    + TBNome.Text + "')";
                cmd.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("Inserido com sucesso!");

                atualizarGrid();

            } catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o cadastro!");
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder criaConexaoBD = new MySqlConnectionStringBuilder();

            criaConexaoBD.Server = "localhost";
            criaConexaoBD.Database = "visualstudio";
            criaConexaoBD.UserID = "root";
            criaConexaoBD.Password = "";

            MySqlConnection realizaConexaoBD = new MySqlConnection(criaConexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand cmd = realizaConexaoBD.CreateCommand();
                cmd.CommandText = "SELECT * FROM cadastro";
                MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    dataGridView1.Rows.Add(row);
                }

                realizaConexaoBD.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível encontrar os dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder criaConexaoBD = new MySqlConnectionStringBuilder();

            criaConexaoBD.Server = "localhost";
            criaConexaoBD.Database = "visualstudio";
            criaConexaoBD.UserID = "root";
            criaConexaoBD.Password = "";

            MySqlConnection realizaConexaoBD = new MySqlConnection(criaConexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

                MySqlCommand cmd = realizaConexaoBD.CreateCommand();
                cmd.CommandText = "DELETE FROM cadastro WHERE id = " + id;
                cmd.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("Removido com sucesso!");

                atualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a solicitação!");
                Console.WriteLine(ex.Message);
            }
        }
    }



}
