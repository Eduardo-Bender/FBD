using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FBD.Global;

namespace FBD
{
    public class Peca
    {
        private int id;
        private string designacao;
        private int custo_unitario;
        private int quantidade_armazem;

        public string Designacao
        {
            get { return designacao; }
            set { designacao = value; }
        }

        public int CustoUnitario
        {
            get { return custo_unitario; }
            set { custo_unitario = value; }
        }

        public int QuantidadeArmazem
        {
            get { return quantidade_armazem; }
            set { quantidade_armazem = value; }
        }

        public Peca()
        {
            id = 0;
            designacao = string.Empty;
            custo_unitario = 0;
            quantidade_armazem = 0;
        }

        public Peca(string designacao, int custo_unitario, int quantidade_armazem)
        {
            this.designacao = designacao;
            this.custo_unitario = custo_unitario;
            this.quantidade_armazem = quantidade_armazem;
        }

        public void InserirPeca()
        {
            try
            {
                Conexao.Open();

                string query = "INSERT INTO Pecas (Designacao, Custo_Unitario, Quantidade_Armazem) VALUES (@Designacao, @Custo_Unitario, @Quantidade_Armazem)";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@Designacao", Designacao);
                command.Parameters.AddWithValue("@Custo_Unitario", CustoUnitario);
                command.Parameters.AddWithValue("@Quantidade_Armazem", QuantidadeArmazem);

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

        public void AtualizarPeca(int Id)
        {
            try
            {
                Conexao.Open();

                string query = "UPDATE Pecas SET Designacao = @Designacao, Custo_Unitario = @Custo_Unitario, Quantidade_Armazem = @Quantidade_Armazem WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Designacao", Designacao);
                command.Parameters.AddWithValue("@Custo_Unitario", CustoUnitario);
                command.Parameters.AddWithValue("@Quantidade_Armazem", QuantidadeArmazem);

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

        public void ExcluirPeca(int Id)
        {
            try
            {
                Conexao.Open();

                string query = "DELETE FROM Pecas WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@Id", Id);

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

        public void ListaPecas(string t, ListView lista_pecas)
        {
            try
            {
                Conexao.Open();

                string query = "select * from pecas where designacao like @q";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@q", "%" + t + "%");

                lista_pecas.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row =
                    {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                };

                    lista_pecas.Items.Add(new ListViewItem(row));
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

        public void RefrescaPecas(ListView lista_pecas)
        {
            try
            {
                Conexao.Open();

                string query = "select * from pecas order by id desc";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.Clear();

                lista_pecas.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row =
                    {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                };

                    lista_pecas.Items.Add(new ListViewItem(row));
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
