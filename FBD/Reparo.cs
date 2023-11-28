using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FBD.Global;

namespace FBD
{
    public class Reparo
    {
        private int id;
        private int idCliente;
        private int idVeiculo;
        private int idTrabalho;
        private int custo;
        private DateTime dataReparo;

        public Reparo()
        {
            id = 0 ;
            idCliente = 0;
            idVeiculo = 0;
            idTrabalho = 0;
            custo = 0;
            dataReparo = DateTime.MinValue;
        }

        public Reparo(int id_Cliente, int id_Veiculo, int id_Trabalho, int custo_Total, DateTime data_do_reparo)
        {
            idCliente = id_Cliente;
            idVeiculo = id_Veiculo;
            idTrabalho = id_Trabalho;
            custo = custo_Total;
            dataReparo = data_do_reparo;
        }


        public void InserirReparo()
        {
            try
            {
                Conexao.Open();

                string query = "INSERT INTO reparos (id_cliente, id_veiculo, id_trabalho, data_reparo, custo_total) VALUES (@id_cliente, @id_veiculo, @id_trabalho, " +
                                "@data_reparo, @custo_total)";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id_cliente", idCliente);
                command.Parameters.AddWithValue("@id_veiculo", idVeiculo);
                command.Parameters.AddWithValue("@id_trabalho", idTrabalho);
                command.Parameters.AddWithValue("@data_reparo", dataReparo);
                command.Parameters.AddWithValue("@custo_total", custo);


                command.ExecuteNonQuery();

                MessageBox.Show("Inserido", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void AtualizarMao_de_Obra(int id_reparo)
        {
            try
            {
                Conexao.Open();

                string query = "UPDATE reparos SET id_cliente = @id_cliente, id_veiculo = @id_veiculo, id_trabalho = @id_trabalho, " +
                                "data_reparo = @data_reparo, custo_total = @custo_total WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id", id_reparo);
                command.Parameters.AddWithValue("@id_cliente", idCliente);
                command.Parameters.AddWithValue("@id_veiculo", idVeiculo);
                command.Parameters.AddWithValue("@id_trabalho", idTrabalho);
                command.Parameters.AddWithValue("@data_reparo", dataReparo);
                command.Parameters.AddWithValue("@custo_total", custo);

                command.ExecuteNonQuery();

                MessageBox.Show("Atualizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void ExcluirReparo(int id_reparo)
        {
            try
            {
                Conexao.Open();

                string query = "DELETE FROM reparo WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id", id_reparo);

                command.ExecuteNonQuery();

                MessageBox.Show("Excluído", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void ListaReparo(string t, ListView lista_Reparos)
        {
            try
            {
                Conexao.Open();

                string query = "select reparos.id, clientes.nome, reparos.id_veiculo, reparos.data_reparo, mao_de_obra.trabalho, reparos.custo_total" +
                               " from reparos INNER JOIN clientes ON reparos.id_cliente = clientes.ID INNER JOIN" +
                               " veiculos on reparos.id_veiculo = veiculos.ID INNER JOIN mao_de_obra on reparos.id_trabalho = mao_de_obra.trabalho" +
                               " WHERE clientes.Nome like @q";


                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@q", "%" + t + "%");

                lista_Reparos.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row =
                    {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                };

                    lista_Reparos.Items.Add(new ListViewItem(row));
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

        public void RefrescaReparos(ListView lista_Reparos)
        {
            try
            {
                Conexao.Open();
                string query = "select reparos.id, clientes.nome, reparos.id_veiculo, reparos.data_reparo, mao_de_obra.trabalho, reparos.custo_total" +
                               " from reparos INNER JOIN clientes ON reparos.id_cliente = clientes.ID INNER JOIN" +
                               " veiculos on reparos.id_veiculo = veiculos.ID INNER JOIN mao_de_obra on reparos.id_trabalho = mao_de_obra.trabalho" +
                               " order by trabalho desc";

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.Clear();

                lista_Reparos.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row =
                    {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                };

                    lista_Reparos.Items.Add(new ListViewItem(row));
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
