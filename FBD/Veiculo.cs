using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FBD.Global;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FBD
{
    public class Veiculo
    {
        private int idVeiculo;
        private DateTime dataAquisicao;
        private int idCliente;

        public DateTime DataAquisicao
        {
            get { return dataAquisicao; }
            set { dataAquisicao = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public Veiculo()
        {
            idVeiculo = 0;
            dataAquisicao = DateTime.MinValue;
            idCliente = 0;
        }

        public Veiculo(DateTime dataAquisicao, int idCliente)
        {
            this.dataAquisicao = dataAquisicao;
            this.idCliente = idCliente;
        }

        public void InserirVeiculo()
        {
            try
            {
                Conexao.Open();

                string query = "INSERT INTO Veiculos (Data_Aquisicao, ID_Cliente) VALUES (@Data_Aquisicao, @ID_Cliente)";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@Data_Aquisicao", DataAquisicao.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@ID_Cliente", IdCliente);

                command.ExecuteNonQuery();

                MessageBox.Show("Veículo Inserido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void AtualizarVeiculo(int idVeiculo)
        {
            try
            {
                Conexao.Open();

                string query = "UPDATE Veiculos SET Data_Aquisicao = @Data_Aquisicao WHERE ID = @ID_Veiculo";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@ID_Veiculo", idVeiculo);
                command.Parameters.AddWithValue("@Data_Aquisicao", DataAquisicao.ToString("yyyy-MM-dd"));

                command.ExecuteNonQuery();

                MessageBox.Show("Veículo Atualizado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void ExcluirVeiculo(int idVeiculo)
        {
            try
            {
                Conexao.Open();

                string query = "DELETE FROM Veiculos WHERE ID = @ID";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@ID", idVeiculo);

                command.ExecuteNonQuery();

                MessageBox.Show("Veículo Excluído com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void ListaVeiculos(ListView lista_veiculos)
        {
            try
            {
                Conexao.Open();

                string query = "SELECT Veiculos.ID, Veiculos.Data_Aquisicao, Clientes.Nome, Veiculos.ID_Cliente FROM Veiculos INNER JOIN Clientes " +
                                "ON Veiculos.ID_Cliente = Clientes.ID WHERE Veiculos.ID_Cliente = @ID_Cliente";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Cliente", IdCliente);
                lista_veiculos.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                lista_veiculos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                    reader.GetString(0),
                    reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                    reader.GetString(2),
                    reader.GetString(3),
                };

                    lista_veiculos.Items.Add(new ListViewItem(row));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void RefrescaVeiculos(ListView lista_veiculos)
        {
            try
            {
                Conexao.Open();
                string query = "SELECT Veiculos.ID, Veiculos.Data_Aquisicao, Clientes.Nome, Veiculos.ID_Cliente " +
                               "FROM Veiculos " +
                               "JOIN Clientes ON Veiculos.ID_Cliente = Clientes.ID " +
                               "ORDER BY Veiculos.ID DESC;"
                ;
                MySqlCommand cmd = new MySqlCommand(query, Conexao);


                cmd.Parameters.Clear();

                lista_veiculos.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                lista_veiculos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    lista_veiculos.Items.Add(new ListViewItem(row));

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

    }

}
