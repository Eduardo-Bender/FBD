using MySql.Data.MySqlClient;

namespace FBD
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=admin;database=bd_fbd";
        private bool funcionario;
        public Form1()
        {
            InitializeComponent();
            lista_pessoas.View = View.Details;
            lista_pessoas.LabelEdit = true;
            lista_pessoas.AllowColumnReorder = true;
            lista_pessoas.FullRowSelect = true;

            lista_pessoas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Morada", 100, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.conectarPrimeiraVez();
            funcionario = false;
            comboBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "insert into clientes (nome, morada, telefone) " +
                             "values('" + txtNome.Text + "', '" + txtMorada.Text + "', '" + txtTelefone.Text + "') ";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Inserido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (funcionario)
            {
                try
                {
                    string q = "'%" + txtBuscar.Text + "%'";
                    Conexao = new MySqlConnection(data_source);
                    string sql = "select * from funcionarios where nome like " + q;
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, Conexao);
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
                        var linha_listview = new ListViewItem(row);

                        lista_pessoas.Items.Add(linha_listview);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
            else
            {
                try
                {
                    string q = "'%" + txtBuscar.Text + "%'";
                    Conexao = new MySqlConnection(data_source);
                    string sql = "select * from clientes where nome like " + q;
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, Conexao);
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
                    };
                        var linha_listview = new ListViewItem(row);

                        lista_pessoas.Items.Add(linha_listview);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                funcionario = true;
                comboBox1.Enabled = true;
                lista_pessoas.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
            }
            else
            {
                funcionario = false;
                comboBox1.Enabled = false;
                lista_pessoas.Columns.RemoveAt(4);
            }
        }
    }
}