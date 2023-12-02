using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

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
                                       "(id integer not null auto_increment primary key, " +
                                       "nome char(40), " +
                                       "morada char(40), " +
                                       "telefone int(11))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS funcionarios " +
                                       "(id integer not null auto_increment primary key, " +
                                       "nome char(40), " +
                                       "morada char(40), " +
                                       "telefone int(11), " +
                                       "categoria char(20))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS veiculos " +
                                       "(id integer not null auto_increment primary key, " + 
                                       "id_cliente int, foreign key (id_cliente) references clientes(id), " +
                                       "data_aquisicao date)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS pecas " +
                                       "(id integer not null auto_increment primary key, " +
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
                                       "(id integer not null auto_increment primary key, " +
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

            try
            {
                Comando = new MySqlCommand("CREATE VIEW bd_fbd.reparoView AS select reparos.id, clientes.nome, reparos.id_veiculo, reparos.data_reparo, mao_de_obra.trabalho, reparos.custo_total" +
                                   " from bd_fbd.reparos INNER JOIN bd_fbd.clientes ON reparos.id_cliente = clientes.ID INNER JOIN" +
                                   " bd_fbd.veiculos on reparos.id_veiculo = veiculos.ID INNER JOIN bd_fbd.mao_de_obra on reparos.trabalho = mao_de_obra.trabalho" +
                                   " order by trabalho desc", Conexao);
                Comando.ExecuteNonQuery();

                MySqlCommand comandoMaoDeObraView = new MySqlCommand(
                                    "CREATE VIEW bd_fbd.mao_de_obraView AS " +
                                    "SELECT Mao_de_obra.trabalho, Funcionarios.Nome, Pecas.Designacao, Mao_de_obra.Tempo, Mao_de_obra.Custo " +
                                    "FROM bd_fbd.Mao_de_obra " +
                                    "INNER JOIN bd_fbd.Funcionarios ON Mao_de_obra.ID_Funcionario = Funcionarios.ID " +
                                    "INNER JOIN bd_fbd.Pecas ON Mao_de_obra.ID_Peca = Pecas.ID " +
                                    "ORDER BY Mao_de_obra.trabalho DESC;", Conexao);
                comandoMaoDeObraView.ExecuteNonQuery();



            }
            catch (MySqlException ex)
            {
                if(ex.Code == 1050)
                {
                    MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS HISTORICOclientes " +
                                       "(id integer not null auto_increment primary key, " +
                                       "nome char(40), " +
                                       "morada char(40), " +
                                       "telefone int(11))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS HISTORICOfuncionarios " +
                                       "(id integer not null auto_increment primary key, " +
                                       "nome char(40), " +
                                       "morada char(40), " +
                                       "telefone int(11), " +
                                       "categoria char(20))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS HISTORICOveiculos " +
                                       "(id integer not null auto_increment primary key, " +
                                       "id_cliente int, foreign key (id_cliente) references HISTORICOclientes(id), " +
                                       "data_aquisicao date)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS HISTORICOpecas " +
                                       "(id integer not null auto_increment primary key, " +
                                       "designacao char(40), " +
                                       "custo_unitario int(5), " +
                                       "quantidade_armazem int(10))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS HISTORICOmao_de_obra " +
                                       "(trabalho integer primary key, " +
                                       "id_funcionario int, foreign key (id_funcionario) references HISTORICOfuncionarios(id), " +
                                       "id_peca int, foreign key (id_peca) references HISTORICOpecas(id), " +
                                       "custo int(10), " +
                                       "tempo int(10))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS HISTORICOreparos " +
                                       "(id integer not null auto_increment primary key, " +
                                       "id_cliente int, foreign key (id_cliente) references HISTORICOclientes(id), " +
                                       "id_veiculo int, foreign key (id_veiculo) references HISTORICOveiculos(id), " +
                                       "trabalho int, foreign key (trabalho) references HISTORICOmao_de_obra(trabalho), " +
                                       "data_reparo date, " +
                                       "custo_total int(10))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand(" CREATE TRIGGER IF NOT EXISTS before_delete_cliente2 \r\nBEFORE DELETE ON bd_fbd.Clientes \r\nFOR EACH ROW" +
                                       "\r\n\tINSERT INTO HISTORICOClientes (Nome, Morada, Telefone) \nVALUES (OLD.Nome, OLD.Morada, OLD.Telefone);" +
                                       "\r\n", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TRIGGER IF NOT EXISTS before_delete_funcionarios2 " +
                                       "BEFORE DELETE " +
                                        "ON bd_fbd.HISTORICOfuncionarios " +
                                        "FOR EACH ROW" +
                                            " INSERT INTO HISTORICOfuncionarios(nome, morada, telefone, categoria)" +
                                            " VALUES(OLD.nome, OLD.morada, OLD.telefone, OLD.categoria);", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TRIGGER IF NOT EXISTS before_delete_veiculos2 " +
                                        "BEFORE DELETE " +
                                        "ON bd_fbd.HISTORICOveiculos " +
                                        "FOR EACH ROW" +
                                        " INSERT INTO HISTORICOveiculos(id_cliente, data_aquisicao)" +
                                        " VALUES(OLD.id_cliente, OLD.data_aquisicao);", Conexao);
            Comando.ExecuteNonQuery();


            MySqlCommand comandoPecas = new MySqlCommand(
                                        "CREATE TRIGGER IF NOT EXISTS before_delete_pecas2 " +
                                        "BEFORE DELETE " +
                                        "ON bd_fbd.HISTORICOpecas " +
                                        "FOR EACH ROW" +
                                        " INSERT INTO HISTORICOpecas(designacao, custo_unitario, quantidade_armazem)" +
                                        " VALUES(OLD.designacao, OLD.custo_unitario, OLD.quantidade_armazem);", Conexao);
            comandoPecas.ExecuteNonQuery();


            MySqlCommand comandoMaoDeObra = new MySqlCommand(
                                        "CREATE TRIGGER IF NOT EXISTS before_delete_mao_de_obra2 " +
                                        "BEFORE DELETE " +
                                        "ON bd_fbd.HISTORICOmao_de_obra " +
                                        "FOR EACH ROW" +
                                        " INSERT INTO HISTORICOmao_de_obra(id_funcionario, id_peca, custo, tempo)" +
                                        " VALUES(OLD.id_funcionario, OLD.id_peca, OLD.custo, OLD.tempo);", Conexao);
            comandoMaoDeObra.ExecuteNonQuery();

            MySqlCommand comandoReparos = new MySqlCommand(
                                        "CREATE TRIGGER IF NOT EXISTS before_delete_reparos2 " +
                                        "BEFORE DELETE " +
                                        "ON bd_fbd.HISTORICOreparos " +
                                        "FOR EACH ROW" +
                                        " INSERT INTO HISTORICOreparos(id_cliente, id_veiculo, trabalho, data_reparo, custo_total)" +
                                        " VALUES(OLD.id_cliente, OLD.id_veiculo, OLD.trabalho, OLD.data_reparo, OLD.custo_total);", Conexao);
            comandoReparos.ExecuteNonQuery();




            Conexao.Close();
        }
    
    }

}
