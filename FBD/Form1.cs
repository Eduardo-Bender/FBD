using MySql.Data.MySqlClient;
using static FBD.Global;

namespace FBD
{
    public partial class Form1 : Form
    {
        private int? id_contato_selecionado = null;
        private string? categoria_selecionada = null;
        private bool funcionario;
        public Form1()
        {
            InitializeComponent();
            lista_pessoas.View = View.Details;
            lista_pessoas.LabelEdit = true;
            lista_pessoas.AllowColumnReorder = true;
            lista_pessoas.FullRowSelect = true;
            lista_veiculos.View = View.Details;
            lista_veiculos.LabelEdit = true;
            lista_veiculos.AllowColumnReorder = true;
            lista_veiculos.FullRowSelect = true;

            lista_pessoas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Morada", 100, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            lista_veiculos.Columns.Add("ID Veiculo", 100, HorizontalAlignment.Left);
            lista_veiculos.Columns.Add("Data de aquisição", 120, HorizontalAlignment.Left);
            lista_veiculos.Columns.Add("Nome do Cliente", 120, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.conectarPrimeiraVez();
            funcionario = false;
            comboBox1.Enabled = false;
            carregar_pessoas();
            carregar_veiculos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_contato_selecionado == null)
            {
                if (funcionario)
                {
                    Funcionario funcionario = new Funcionario(txtNome.Text, txtMorada.Text, txtTelefone.Text, categoria_selecionada);
                    funcionario.InserirFuncionario();
                }
                else
                {
                    Cliente cliente = new Cliente(txtNome.Text, txtMorada.Text, txtTelefone.Text);
                    cliente.InserirCliente();
                }
            }
            else
            {
                if (funcionario)
                {
                    Funcionario funcionario = new Funcionario(txtNome.Text, txtMorada.Text, txtTelefone.Text, categoria_selecionada);
                    funcionario.AtualizarFuncionario(Convert.ToInt32(id_contato_selecionado));
                }
                else
                {
                    Cliente cliente = new Cliente(txtNome.Text, txtMorada.Text, txtTelefone.Text);
                    cliente.AtualizarCliente(Convert.ToInt32(id_contato_selecionado));
                }
            }

            carregar_pessoas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (funcionario)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.ListaFuncionarios(txtBuscar.Text, lista_pessoas);
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.ListaClientes(txtBuscar.Text, lista_pessoas);
            }
        }

        private void carregar_pessoas()
        {
            if (funcionario)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.RefrescaFuncionarios(lista_pessoas);
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.RefrescaClientes(lista_pessoas);
            }
        }

        private void carregar_veiculos()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.RefrescaVeiculos(lista_veiculos);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                funcionario = true;
                comboBox1.Enabled = true;
                lista_veiculos.Enabled = false;
                txtVeiculo.Enabled = false;
                btn_salva_veiculo.Enabled = false;
                lista_pessoas.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
                carregar_pessoas();
                button1.Enabled = false;
            }
            else
            {
                funcionario = false;
                comboBox1.Enabled = false;
                lista_veiculos.Enabled = true;
                txtVeiculo.Enabled = true;
                if (id_contato_selecionado != null)
                    btn_salva_veiculo.Enabled = true;
                lista_pessoas.Columns.RemoveAt(4);
                carregar_pessoas();
                button1.Enabled = true;
            }
        }

        private void lista_pessoas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(!funcionario)
                btn_salva_veiculo.Enabled = true;
            ListView.SelectedListViewItemCollection itens_selecionados = lista_pessoas.SelectedItems;
            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtNome.Text = item.SubItems[1].Text;
                txtMorada.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
            }
            Veiculo veiculo = new Veiculo();
            veiculo.IdCliente = Convert.ToInt32(id_contato_selecionado);
            veiculo.ListaVeiculos(lista_veiculos);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (funcionario)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.ExcluirFuncionario(Convert.ToInt32(id_contato_selecionado));
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.ExcluirCliente(Convert.ToInt32(id_contato_selecionado));
            }

            limpa_campos();
            carregar_pessoas();
            carregar_veiculos();
        }

        private void limpa_campos()
        {
            txtNome.Clear();
            txtMorada.Clear();
            txtTelefone.Clear();
            id_contato_selecionado = null;
            if (funcionario)
            {
                categoria_selecionada = null;
                button1.Enabled = false;

            }
            comboBox1.Text = "Selecione uma categoria";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            limpa_campos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoria_selecionada = comboBox1.Text;
            button1.Enabled = true;
        }

        private void btn_salva_veiculo_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo(txtVeiculo.Value, Convert.ToInt32(id_contato_selecionado));
            veiculo.InserirVeiculo();
            carregar_veiculos();
        }

        private void lista_pessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lista_pessoas.SelectedItems.Count == 0)
            {
                limpa_campos();
                carregar_veiculos();

            }
        }
    }
}