using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FBD
{
    class Global
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable datTabela;

        public static void conectarPrimeiraVez()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=admin");

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



            Conexao.Close();
        }
    
    }

}
