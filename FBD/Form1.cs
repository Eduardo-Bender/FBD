using MySql.Data.MySqlClient;
using static FBD.Global;

namespace FBD
{
    public partial class Form1 : Form
    {
        private int? id_contato_selecionado = null;

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
            carregar_pessoas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_contato_selecionado == null)
            {

                Cliente cliente = new Cliente(txtNome.Text, txtMorada.Text, txtTelefone.Text);
                cliente.InserirCliente();


            }
            else
            {

                Cliente cliente = new Cliente(txtNome.Text, txtMorada.Text, txtTelefone.Text);
                cliente.AtualizarCliente(Convert.ToInt32(id_contato_selecionado));

            }

            carregar_pessoas();
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
                Cliente cliente = new Cliente();
                cliente.ListaClientes(txtBuscar.Text, lista_pessoas);
            }
        }

        private void carregar_pessoas()
        {
            Cliente cliente = new Cliente();
            cliente.RefrescaClientes(lista_pessoas);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                funcionario = true;
                comboBox1.Enabled = true;
                lista_pessoas.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
                carregar_pessoas();
            }
            else
            {
                funcionario = false;
                comboBox1.Enabled = false;
                lista_pessoas.Columns.RemoveAt(4);
                carregar_pessoas();
            }
        }

        private void lista_pessoas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lista_pessoas.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtNome.Text = item.SubItems[1].Text;
                txtMorada.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            cliente.ExcluirCliente(Convert.ToInt32(id_contato_selecionado));
            carregar_pessoas();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMorada.Clear();
            txtTelefone.Clear();
            id_contato_selecionado = null;
        }
    }
}