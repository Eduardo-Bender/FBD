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

            carregar_pessoas();

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

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "insert into clientes (nome, morada, telefone) " +
                                  "values " +
                                  "(@nome, @morada, @telefone) ";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@morada", txtMorada.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Inserido");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (funcionario)
            {
                try
                {

                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "select * from funcionarios where nome like @q or morada like @q or categoria like @q";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");


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
            else
            {
                try
                {

                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "select * from clientes where nome like @q or morada like @q ";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");


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

        private void carregar_pessoas()
        {
            try
            {

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "select * from clientes order by id desc ";

                cmd.Parameters.Clear();


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