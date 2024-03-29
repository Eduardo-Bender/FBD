﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static FBD.Global;

namespace FBD
{
    public class Funcionario
    {
        private int id;
        private string nome;
        private string morada;
        private string telefone;
        private string categoria;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Funcionario()
        {
            id = 0;
            nome = string.Empty;
            morada = string.Empty;
            telefone = string.Empty;
            categoria = string.Empty;
        }

        public Funcionario(string nome, string morada, string telefone, string categoria)
        {
            this.nome = nome;
            this.morada = morada;
            this.telefone = telefone;
            this.categoria = categoria;
        }

        public void InserirFuncionario()
        {
            try
            {
                Conexao.Open();

                string query = "INSERT INTO funcionarios (Nome, Morada, Telefone, categoria) VALUES (@Nome, @Morada, @Telefone, @categoria)";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@Nome", Nome);
                command.Parameters.AddWithValue("@Morada", Morada);
                command.Parameters.AddWithValue("@Telefone", Telefone);
                command.Parameters.AddWithValue("@categoria", categoria);

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

        public void AtualizarFuncionario(int Id)
        {
            try
            {
                Conexao.Open();

                string query = "UPDATE funcionarios SET Nome = @Nome, Morada = @Morada, Telefone = @Telefone, categoria = @categoria WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, Conexao);

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Nome", Nome);
                command.Parameters.AddWithValue("@Morada", Morada);
                command.Parameters.AddWithValue("@Telefone", Telefone);
                command.Parameters.AddWithValue("@categoria", categoria);

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

        public void ExcluirFuncionario(int Id)
        {
            try
            {
                Conexao.Open();

                string query = "DELETE FROM funcionarios WHERE Id = @Id";
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

        public void ListaFuncionarios(string t, ListView lista_pessoas)
        {
            try
            {
                Conexao.Open();

                string query = "select * from funcionarios where nome like @q or morada like @q or categoria like @q";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);


                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@q", "%" + t + "%");


                lista_pessoas.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                lista_pessoas.Items.Clear();

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

                    lista_pessoas.Items.Add(new ListViewItem(row));

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

        public void RefrescaFuncionarios(ListView lista_pessoas)
        {
            try
            {
                Conexao.Open();

                string query = "select * from funcionarios order by id desc ";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);


                cmd.Parameters.Clear();

                lista_pessoas.Items.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                lista_pessoas.Items.Clear();

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

                    lista_pessoas.Items.Add(new ListViewItem(row));

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