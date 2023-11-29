using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FBD.Global;

namespace FBD
{
    public class Mao_de_Obra
    {
        private int trabalho;
        private int idFuncionario;
        private int idPeca;
        private int tempo;
        private int custo;

        public int Trabalho
        {
            get { return trabalho; }
            set { trabalho = value; }
        }

        public int ID_Funcionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }

        public int ID_Peca
        {
            get { return idPeca; }
            set { idPeca = value; }
        }

        public int Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }

        public int Custo
        {
            get { return custo; }
            set { custo = value; }
        }

        public Mao_de_Obra()
        {
            trabalho = 0;
            idFuncionario = 0;
            idPeca = 0;
            tempo = 0;
            custo = 0;
        }

        public Mao_de_Obra(int idFuncionario, int idPeca, int tempo, int custo)
        {
            ID_Funcionario = idFuncionario;
            ID_Peca = idPeca;
            Tempo = tempo;
            Custo = custo;
        }


        public void InserirMao_de_Obra()
        {
            try
            {
                Conexao.Open();

                string query = "INSERT INTO Mao_de_Obra (ID_Funcionario, ID_Peca, Tempo, Custo) VALUES (@idFuncionario, @idPeca, @tempo, @custo)";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                command.Parameters.AddWithValue("@idPeca", idPeca);
                command.Parameters.AddWithValue("@tempo", tempo);
                command.Parameters.AddWithValue("@custo", custo);


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

        public void AtualizarMao_de_Obra(int trabalho)
        {
            try
            {
                Conexao.Open();

                string query = "UPDATE Mao_de_Obra SET ID_Funcionario = @idFuncionario, ID_Peca = @idPeca, tempo = @tempo, custo = @custo WHERE trabalho = @trabalho";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@trabalho", trabalho);
                command.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                command.Parameters.AddWithValue("@idPeca", idPeca);
                command.Parameters.AddWithValue("@tempo", tempo);
                command.Parameters.AddWithValue("@custo", custo);

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

        public void ExcluirMao_de_Obra(int trabalho)
        {
            try
            {
                Conexao.Open();

                string query = "DELETE FROM Mao_de_Obra WHERE trabalho = @trabalho";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@trabalho", trabalho);

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

        public void ListaMao_de_Obras(string t, ListView lista_Mao_de_Obras)
        {
            try
            {
                Conexao.Open();
                

                string query = "select Mao_de_obra.trabalho, Funcionarios.Nome, Pecas.Designacao, Mao_de_obra.Tempo, Mao_de_obra.Custo" +
                               " from Mao_de_obra INNER JOIN Funcionarios ON Mao_de_obra.ID_Funcionario = Funcionarios.ID INNER JOIN" +
                               " Pecas on Mao_de_obra.ID_Peca = Pecas.ID WHERE Funcionarios.Nome like @q or Pecas.Designacao like @q";

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@q", "%" + t + "%");

                lista_Mao_de_Obras.Items.Clear();

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
                };

                    lista_Mao_de_Obras.Items.Add(new ListViewItem(row));
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

        public void RefrescaMao_de_Obras(ListView lista_Mao_de_Obra)
        {
            try
            {
                Conexao.Open();
                string query = "select Mao_de_obra.trabalho, Funcionarios.Nome, Pecas.Designacao, Mao_de_obra.Tempo, Mao_de_obra.Custo" +
                               " from Mao_de_obra INNER JOIN Funcionarios ON Mao_de_obra.ID_Funcionario = Funcionarios.ID INNER JOIN" +
                               " Pecas on Mao_de_obra.ID_Peca = Pecas.ID order by trabalho desc";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.Clear();

                lista_Mao_de_Obra.Items.Clear();

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
                };

                    lista_Mao_de_Obra.Items.Add(new ListViewItem(row));
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
