using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FBD
{
    public static class Global
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable datTabela;

        public static string data_source = "datasource=localhost;username=root;password=admin;database=bd_fbd";

        public static void conectarPrimeiraVez()
        {
            Conexao = new MySqlConnection("datasource=localhost;username=root;password=admin");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_fbd; use bd_fbd", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes " +
                                       "(id integer auto_increment primary key, " +
                                       "nome char(40), " +
                                       "morada char(40), " +
                                       "telefone int(11))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS funcionarios " +
                                       "(id integer auto_increment primary key, " +
                                       "nome char(40), " +
                                       "morada char(40), " +
                                       "telefone int(11), " +
                                       "categoria char(20))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS veiculos " +
                                       "(id integer auto_increment primary key, " + 
                                       "id_cliente int, foreign key (id_cliente) references clientes(id), " +
                                       "data_aquisicao date)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS pecas " +
                                       "(id integer auto_increment primary key, " +
                                       "designacao char(40), " +
                                       "custo_unitario int(5), " +
                                       "quantidade_armazem int(10))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS mao_de_obra " +
                                       "(trabalho integer auto_increment primary key, " +
                                       "id_funcionario int, foreign key (id_funcionario) references funcionarios(id), " +
                                       "id_peca int, foreign key (id_peca) references pecas(id), " +
                                       "custo int(10), " +
                                       "tempo int(10))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS reparos " +
                                       "(id integer auto_increment primary key, " +
                                       "id_cliente int, foreign key (id_cliente) references clientes(id), " +
                                       "id_veiculo int, foreign key (id_veiculo) references veiculos(id), " +
                                       "trabalho int, foreign key (trabalho) references mao_de_obra(trabalho), " +
                                       "data_reparo date, " +
                                       "custo_total int(10))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand(" CREATE TRIGGER IF NOT EXISTS before_delete_cliente \r\nBEFORE DELETE\r\nON bd_fbd.Clientes \r\nFOR EACH ROW     " +
                "\r\n\t-- Exclua os veículos associados ao cliente    \r\nDELETE FROM Veiculos WHERE ID_Cliente = OLD.ID;", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand(" CREATE TRIGGER IF NOT EXISTS before_delete_veiculo \r\nBEFORE DELETE\r\nON bd_fbd.Veiculos \r\nFOR EACH ROW  " +
                "\r\n\t-- Exclua os reparos associados ao veiculo     \r\n    DELETE FROM Reparos \r\n    WHERE ID_Veiculo = OLD.ID;", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand(" CREATE TRIGGER IF NOT EXISTS before_delete_funcionario \r\nBEFORE DELETE \r\nON bd_fbd.Funcionarios \r\nFOR EACH ROW      " +
                "\r\n\t-- Exclua os trabalhos associados ao funcionario     \r\nDELETE FROM mao_de_obra \r\nWHERE ID_Funcionario = OLD.id;", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand(" CREATE TRIGGER IF NOT EXISTS before_delete_peca \r\nBEFORE DELETE \r\nON bd_fbd.pecas \r\nFOR EACH ROW      " +
                "\r\n\t-- Exclua os trabalhos associados a peca     \r\nDELETE FROM mao_de_obra \r\nWHERE ID_Peca = OLD.id;", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand(" CREATE TRIGGER IF NOT EXISTS before_delete_trabalho \r\nBEFORE DELETE \r\nON bd_fbd.mao_de_obra \r\nFOR EACH ROW      " +
                "\r\n\t-- Exclua os reparos associados ao trabalho     \r\nDELETE FROM Reparos \r\nWHERE trabalho = OLD.trabalho;", Conexao);
            Comando.ExecuteNonQuery();


            Conexao.Close();
        }
    
    }

}
