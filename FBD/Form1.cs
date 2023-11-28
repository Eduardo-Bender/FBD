using MySql.Data.MySqlClient;
using static FBD.Global;

namespace FBD
{
    public partial class Form1 : Form
    {
        private int? mostra_id_funcionario = null;
        private int? mostra_id_peca = null;
        private int? id_reparo_selecionado = null;
        private int? trabalho_mao_de_obra_selecionado = null;
        private int? id_peca_selecionado = null;
        private int? id_veiculo_selecionado = null;
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
            lista_pecas.View = View.Details;
            lista_pecas.LabelEdit = true;
            lista_pecas.AllowColumnReorder = true;
            lista_pecas.FullRowSelect = true;
            lista_trabalhos.View = View.Details;
            lista_trabalhos.LabelEdit = true;
            lista_trabalhos.AllowColumnReorder = true;
            lista_trabalhos.FullRowSelect = true;

            lista_pessoas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Morada", 100, HorizontalAlignment.Left);
            lista_pessoas.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            lista_veiculos.Columns.Add("ID Veiculo", 100, HorizontalAlignment.Left);
            lista_veiculos.Columns.Add("Data de aquisição", 120, HorizontalAlignment.Left);
            lista_veiculos.Columns.Add("Nome do Cliente", 120, HorizontalAlignment.Left);

            lista_pecas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lista_pecas.Columns.Add("Designação", 100, HorizontalAlignment.Left);
            lista_pecas.Columns.Add("Custo unitário", 120, HorizontalAlignment.Left);
            lista_pecas.Columns.Add("Armazém", 100, HorizontalAlignment.Left);

            lista_trabalhos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lista_trabalhos.Columns.Add("Funcionario", 100, HorizontalAlignment.Left);
            lista_trabalhos.Columns.Add("Peca", 60, HorizontalAlignment.Left);
            lista_trabalhos.Columns.Add("Tempo", 70, HorizontalAlignment.Left);
            lista_trabalhos.Columns.Add("Custo", 70, HorizontalAlignment.Left);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.conectarPrimeiraVez();
            funcionario = false;
            comboBox1.Enabled = false;
            carregar_pessoas();
            carregar_veiculos();
            carregar_pecas();
            carregar_trabalhos();
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

        private void carregar_trabalhos()
        {
            Mao_de_Obra mao_de_obra = new Mao_de_Obra();
            mao_de_obra.RefrescaMao_de_Obras(lista_trabalhos);
        }

        private void carregar_veiculos()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.RefrescaVeiculos(lista_veiculos);
        }

        private void carregar_pecas()
        {
            Peca peca = new Peca();
            peca.RefrescaPecas(lista_pecas);
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

            if (!funcionario)
                btn_salva_veiculo.Enabled = true;
            ListView.SelectedListViewItemCollection itens_selecionados = lista_pessoas.SelectedItems;
            foreach (ListViewItem item in itens_selecionados)
            {
                if (funcionario)
                {
                    if (lista_pessoas.SelectedItems.Count > 0)
                    {
                        mostra_id_funcionario = Convert.ToInt32(item.SubItems[0].Text);
                        txtMostraFunc.Text = mostra_id_funcionario.ToString();
                    }
                }
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtNome.Text = item.SubItems[1].Text;
                txtMorada.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
            }
            if (mostra_id_funcionario != null && mostra_id_peca != null) btn_salva_trabalho.Enabled = true;

            Veiculo veiculo = new Veiculo();
            veiculo.IdCliente = Convert.ToInt32(id_contato_selecionado);
            veiculo.ListaVeiculos(lista_veiculos);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (id_contato_selecionado != null)
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
            if (id_veiculo_selecionado == null)
            {
                Veiculo veiculo = new Veiculo(txtVeiculo.Value, Convert.ToInt32(id_contato_selecionado));
                veiculo.InserirVeiculo();
            }
            else
            {
                Veiculo veiculo = new Veiculo(txtVeiculo.Value, Convert.ToInt32(id_contato_selecionado));
                veiculo.AtualizarVeiculo(Convert.ToInt32(id_veiculo_selecionado));
            }
            carregar_veiculos();
        }

        private void lista_pessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista_pessoas.SelectedItems.Count == 0)
            {
                limpa_campos();
                carregar_veiculos();

            }
        }

        private void lista_veiculos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection veiculos_selecionados = lista_veiculos.SelectedItems;
            foreach (ListViewItem item in veiculos_selecionados)
            {
                id_veiculo_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtVeiculo.Text = item.SubItems[1].Text;
            }
        }

        private void contextMenuStrip2_Click(object sender, EventArgs e)
        {
            if (id_veiculo_selecionado != null)
            {
                Veiculo veiculo = new Veiculo();
                veiculo.ExcluirVeiculo(Convert.ToInt32(id_veiculo_selecionado));
                carregar_veiculos();
            }
        }

        private void lista_pecas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lista_pecas.SelectedItems.Count == 0)
            {
                limpa_campos_peca();
                id_peca_selecionado = null;
            }
            else
            {
                ListView.SelectedListViewItemCollection pecas_selecionados = lista_pecas.SelectedItems;
                foreach (ListViewItem item in pecas_selecionados)
                {
                    mostra_id_peca = Convert.ToInt32(item.SubItems[0].Text);
                    txtMostraPeca.Text = mostra_id_peca.ToString();
                    id_peca_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                    txtPecaDesign.Text = item.SubItems[1].Text;
                    txtPecaUnit.Text = item.SubItems[2].Text;
                    txtPecaArmaz.Text = item.SubItems[3].Text;
                }

            }
            if (mostra_id_funcionario != null && mostra_id_peca != null) btn_salva_trabalho.Enabled = true;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (id_peca_selecionado != null)
            {
                Peca peca = new Peca();
                peca.ExcluirPeca(Convert.ToInt32(id_peca_selecionado));
                carregar_pecas();
            }
        }

        private void btn_salva_peca_Click(object sender, EventArgs e)
        {
            if (id_peca_selecionado == null)
            {
                Peca peca = new Peca(txtPecaDesign.Text, Convert.ToInt32(txtPecaUnit.Text), Convert.ToInt32(txtPecaArmaz.Text));
                peca.InserirPeca();
            }
            else
            {
                Peca peca = new Peca(txtPecaDesign.Text, Convert.ToInt32(txtPecaUnit.Text), Convert.ToInt32(txtPecaArmaz.Text));
                peca.AtualizarPeca(Convert.ToInt32(id_peca_selecionado));
            }
            carregar_pecas();
        }

        private void limpa_campos_peca()
        {
            txtPecaDesign.Clear();
            txtPecaUnit.Clear();
            txtPecaArmaz.Clear();
            id_peca_selecionado = null;
            carregar_pecas();
        }
        private void btn_limpa_peca_Click(object sender, EventArgs e)
        {
            limpa_campos_peca();
        }

        private void btn_busca_peca_Click(object sender, EventArgs e)
        {
            Peca peca = new Peca();
            peca.ListaPecas(txtBuscaPeca.Text, lista_pecas);
        }

        private void btn_busca_mao_de_obra_Click(object sender, EventArgs e)
        {
            Mao_de_Obra mao_de_obra = new Mao_de_Obra();
            mao_de_obra.ListaMao_de_Obras(txtBuscaMaoDeObra.Text, lista_trabalhos);
        }

        private void btn_salva_trabalho_Click(object sender, EventArgs e)
        {
            if (trabalho_mao_de_obra_selecionado == null)
            {
                Mao_de_Obra mao_de_obra = new Mao_de_Obra(Convert.ToInt32(id_contato_selecionado), Convert.ToInt32(id_peca_selecionado),
                    Convert.ToInt32(txtTempo.Text), Convert.ToInt32(txtCusto.Text));
                mao_de_obra.InserirMao_de_Obra();
            }
            else
            {
                Mao_de_Obra mao_de_obra = new Mao_de_Obra(Convert.ToInt32(id_contato_selecionado), Convert.ToInt32(id_peca_selecionado),
                    Convert.ToInt32(txtTempo.Text), Convert.ToInt32(txtCusto.Text));
                mao_de_obra.AtualizarMao_de_Obra(Convert.ToInt32(trabalho_mao_de_obra_selecionado));
            }
            carregar_trabalhos();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (trabalho_mao_de_obra_selecionado != null)
            {
                Mao_de_Obra mao_de_obra = new Mao_de_Obra();
                mao_de_obra.ExcluirMao_de_Obra(Convert.ToInt32(trabalho_mao_de_obra_selecionado));
                carregar_trabalhos();
            }
        }

        private void btn_limpa_trabalho_Click(object sender, EventArgs e)
        {
            txtTempo.Clear();
            txtCusto.Clear();
            trabalho_mao_de_obra_selecionado = null;
            mostra_id_funcionario = null;
            mostra_id_peca = null;
            btn_salva_trabalho.Enabled = false;
            txtMostraFunc.Clear();
            txtMostraPeca.Clear();
        }
    }
}