namespace FBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtMorada = new TextBox();
            txtTelefone = new TextBox();
            txtBuscar = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lista_pessoas = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            btn_salva_veiculo = new Button();
            label8 = new Label();
            lista_veiculos = new ListView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            txtVeiculo = new DateTimePicker();
            txtPecaDesign = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPecaUnit = new TextBox();
            label9 = new Label();
            txtPecaArmaz = new TextBox();
            lista_pecas = new ListView();
            contextMenuStrip3 = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            btn_limpa_peca = new Button();
            btn_salva_peca = new Button();
            btn_busca_peca = new Button();
            txtBuscaPeca = new TextBox();
            label10 = new Label();
            lista_trabalhos = new ListView();
            contextMenuStrip4 = new ContextMenuStrip(components);
            toolStripMenuItem4 = new ToolStripMenuItem();
            btn_busca_mao_de_obra = new Button();
            txtBuscaMaoDeObra = new TextBox();
            txtCusto = new TextBox();
            txtTempo = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btn_limpa_trabalho = new Button();
            btn_salva_trabalho = new Button();
            txtMostraFunc = new TextBox();
            txtMostraPeca = new TextBox();
            label5 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtMostraTrab = new TextBox();
            txtMostraVeic = new TextBox();
            button4 = new Button();
            btn_salva_reparo = new Button();
            lista_reparos = new ListView();
            contextMenuStrip5 = new ContextMenuStrip(components);
            toolStripMenuItem5 = new ToolStripMenuItem();
            btn_busca_reparo = new Button();
            txtBuscaReparo = new TextBox();
            txtReparoCustoTotal = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            dataReparo = new DateTimePicker();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            contextMenuStrip4.SuspendLayout();
            contextMenuStrip5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 74);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 138);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "Morada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 206);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(239, 74);
            label4.Name = "label4";
            label4.Size = new Size(171, 17);
            label4.TabIndex = 3;
            label4.Text = "Buscar cliente/funcionário";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 96);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(181, 27);
            txtNome.TabIndex = 4;
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(33, 158);
            txtMorada.Margin = new Padding(3, 4, 3, 4);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(181, 27);
            txtMorada.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(33, 226);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(181, 27);
            txtTelefone.TabIndex = 6;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(239, 96);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(471, 27);
            txtBuscar.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(129, 266);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(718, 96);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 9;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lista_pessoas
            // 
            lista_pessoas.ContextMenuStrip = contextMenuStrip1;
            lista_pessoas.ImeMode = ImeMode.NoControl;
            lista_pessoas.Location = new Point(239, 142);
            lista_pessoas.Margin = new Padding(3, 4, 3, 4);
            lista_pessoas.MultiSelect = false;
            lista_pessoas.Name = "lista_pessoas";
            lista_pessoas.Size = new Size(565, 154);
            lista_pessoas.TabIndex = 10;
            lista_pessoas.UseCompatibleStateImageBehavior = false;
            lista_pessoas.ItemSelectionChanged += lista_pessoas_ItemSelectionChanged;
            lista_pessoas.SelectedIndexChanged += lista_pessoas_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 28);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(121, 24);
            toolStripMenuItem1.Text = "Excluir";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(33, 32);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Funcionario";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.ForeColor = SystemColors.MenuText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Mecanico", "Estagiario" });
            comboBox1.Location = new Point(146, 30);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 28);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Selecione uma categoria";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(33, 266);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 30);
            button3.TabIndex = 13;
            button3.Text = "Limpar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_salva_veiculo
            // 
            btn_salva_veiculo.Enabled = false;
            btn_salva_veiculo.Location = new Point(129, 392);
            btn_salva_veiculo.Margin = new Padding(3, 4, 3, 4);
            btn_salva_veiculo.Name = "btn_salva_veiculo";
            btn_salva_veiculo.Size = new Size(86, 30);
            btn_salva_veiculo.TabIndex = 22;
            btn_salva_veiculo.Text = "Salvar";
            btn_salva_veiculo.UseVisualStyleBackColor = true;
            btn_salva_veiculo.Click += btn_salva_veiculo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 326);
            label8.Name = "label8";
            label8.Size = new Size(190, 17);
            label8.TabIndex = 14;
            label8.Text = "Data de aquisicao do veiculo";
            // 
            // lista_veiculos
            // 
            lista_veiculos.ContextMenuStrip = contextMenuStrip2;
            lista_veiculos.Location = new Point(239, 340);
            lista_veiculos.Margin = new Padding(3, 4, 3, 4);
            lista_veiculos.Name = "lista_veiculos";
            lista_veiculos.Size = new Size(565, 128);
            lista_veiculos.TabIndex = 26;
            lista_veiculos.UseCompatibleStateImageBehavior = false;
            lista_veiculos.ItemSelectionChanged += lista_veiculos_ItemSelectionChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(122, 28);
            contextMenuStrip2.Click += contextMenuStrip2_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(121, 24);
            toolStripMenuItem2.Text = "Excluir";
            // 
            // txtVeiculo
            // 
            txtVeiculo.Format = DateTimePickerFormat.Short;
            txtVeiculo.Location = new Point(33, 354);
            txtVeiculo.Margin = new Padding(3, 4, 3, 4);
            txtVeiculo.Name = "txtVeiculo";
            txtVeiculo.Size = new Size(181, 27);
            txtVeiculo.TabIndex = 27;
            // 
            // txtPecaDesign
            // 
            txtPecaDesign.Location = new Point(33, 516);
            txtPecaDesign.Margin = new Padding(3, 4, 3, 4);
            txtPecaDesign.Name = "txtPecaDesign";
            txtPecaDesign.Size = new Size(181, 27);
            txtPecaDesign.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 494);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 29;
            label6.Text = "Designação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 554);
            label7.Name = "label7";
            label7.Size = new Size(95, 17);
            label7.TabIndex = 31;
            label7.Text = "Custo unitário";
            // 
            // txtPecaUnit
            // 
            txtPecaUnit.Location = new Point(33, 574);
            txtPecaUnit.Margin = new Padding(3, 4, 3, 4);
            txtPecaUnit.Name = "txtPecaUnit";
            txtPecaUnit.Size = new Size(181, 27);
            txtPecaUnit.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 612);
            label9.Name = "label9";
            label9.Size = new Size(144, 17);
            label9.TabIndex = 33;
            label9.Text = "Quantidade armazem";
            // 
            // txtPecaArmaz
            // 
            txtPecaArmaz.Location = new Point(33, 634);
            txtPecaArmaz.Margin = new Padding(3, 4, 3, 4);
            txtPecaArmaz.Name = "txtPecaArmaz";
            txtPecaArmaz.Size = new Size(181, 27);
            txtPecaArmaz.TabIndex = 32;
            // 
            // lista_pecas
            // 
            lista_pecas.ContextMenuStrip = contextMenuStrip3;
            lista_pecas.Location = new Point(238, 554);
            lista_pecas.Margin = new Padding(3, 4, 3, 4);
            lista_pecas.Name = "lista_pecas";
            lista_pecas.Size = new Size(565, 166);
            lista_pecas.TabIndex = 34;
            lista_pecas.UseCompatibleStateImageBehavior = false;
            lista_pecas.ItemSelectionChanged += lista_pecas_ItemSelectionChanged;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(24, 24);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            contextMenuStrip3.Name = "contextMenuStrip1";
            contextMenuStrip3.Size = new Size(122, 28);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(121, 24);
            toolStripMenuItem3.Text = "Excluir";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // btn_limpa_peca
            // 
            btn_limpa_peca.Location = new Point(33, 678);
            btn_limpa_peca.Margin = new Padding(3, 4, 3, 4);
            btn_limpa_peca.Name = "btn_limpa_peca";
            btn_limpa_peca.Size = new Size(86, 30);
            btn_limpa_peca.TabIndex = 36;
            btn_limpa_peca.Text = "Limpar";
            btn_limpa_peca.UseVisualStyleBackColor = true;
            btn_limpa_peca.Click += btn_limpa_peca_Click;
            // 
            // btn_salva_peca
            // 
            btn_salva_peca.Location = new Point(129, 678);
            btn_salva_peca.Margin = new Padding(3, 4, 3, 4);
            btn_salva_peca.Name = "btn_salva_peca";
            btn_salva_peca.Size = new Size(86, 30);
            btn_salva_peca.TabIndex = 35;
            btn_salva_peca.Text = "Salvar";
            btn_salva_peca.UseVisualStyleBackColor = true;
            btn_salva_peca.Click += btn_salva_peca_Click;
            // 
            // btn_busca_peca
            // 
            btn_busca_peca.Location = new Point(717, 514);
            btn_busca_peca.Margin = new Padding(3, 4, 3, 4);
            btn_busca_peca.Name = "btn_busca_peca";
            btn_busca_peca.Size = new Size(86, 30);
            btn_busca_peca.TabIndex = 39;
            btn_busca_peca.Text = "Buscar";
            btn_busca_peca.UseVisualStyleBackColor = true;
            btn_busca_peca.Click += btn_busca_peca_Click;
            // 
            // txtBuscaPeca
            // 
            txtBuscaPeca.Location = new Point(238, 514);
            txtBuscaPeca.Margin = new Padding(3, 4, 3, 4);
            txtBuscaPeca.Name = "txtBuscaPeca";
            txtBuscaPeca.Size = new Size(471, 27);
            txtBuscaPeca.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(238, 494);
            label10.Name = "label10";
            label10.Size = new Size(87, 17);
            label10.TabIndex = 37;
            label10.Text = "Buscar peça";
            // 
            // lista_trabalhos
            // 
            lista_trabalhos.ContextMenuStrip = contextMenuStrip4;
            lista_trabalhos.Location = new Point(1040, 142);
            lista_trabalhos.Margin = new Padding(3, 4, 3, 4);
            lista_trabalhos.MultiSelect = false;
            lista_trabalhos.Name = "lista_trabalhos";
            lista_trabalhos.Size = new Size(565, 154);
            lista_trabalhos.TabIndex = 47;
            lista_trabalhos.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.ImageScalingSize = new Size(24, 24);
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            contextMenuStrip4.Name = "contextMenuStrip1";
            contextMenuStrip4.Size = new Size(122, 28);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(121, 24);
            toolStripMenuItem4.Text = "Excluir";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // btn_busca_mao_de_obra
            // 
            btn_busca_mao_de_obra.Location = new Point(1519, 96);
            btn_busca_mao_de_obra.Margin = new Padding(3, 4, 3, 4);
            btn_busca_mao_de_obra.Name = "btn_busca_mao_de_obra";
            btn_busca_mao_de_obra.Size = new Size(86, 30);
            btn_busca_mao_de_obra.TabIndex = 46;
            btn_busca_mao_de_obra.Text = "Buscar";
            btn_busca_mao_de_obra.UseVisualStyleBackColor = true;
            btn_busca_mao_de_obra.Click += btn_busca_mao_de_obra_Click;
            // 
            // txtBuscaMaoDeObra
            // 
            txtBuscaMaoDeObra.Location = new Point(1040, 96);
            txtBuscaMaoDeObra.Margin = new Padding(3, 4, 3, 4);
            txtBuscaMaoDeObra.Name = "txtBuscaMaoDeObra";
            txtBuscaMaoDeObra.Size = new Size(471, 27);
            txtBuscaMaoDeObra.TabIndex = 45;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(834, 158);
            txtCusto.Margin = new Padding(3, 4, 3, 4);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(181, 27);
            txtCusto.TabIndex = 44;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(834, 96);
            txtTempo.Margin = new Padding(3, 4, 3, 4);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(181, 27);
            txtTempo.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1040, 74);
            label11.Name = "label11";
            label11.Size = new Size(108, 17);
            label11.TabIndex = 42;
            label11.Text = "Buscar trabalho";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(834, 138);
            label12.Name = "label12";
            label12.Size = new Size(44, 17);
            label12.TabIndex = 41;
            label12.Text = "Custo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(834, 74);
            label13.Name = "label13";
            label13.Size = new Size(52, 17);
            label13.TabIndex = 40;
            label13.Text = "Tempo";
            // 
            // btn_limpa_trabalho
            // 
            btn_limpa_trabalho.Location = new Point(833, 252);
            btn_limpa_trabalho.Margin = new Padding(3, 4, 3, 4);
            btn_limpa_trabalho.Name = "btn_limpa_trabalho";
            btn_limpa_trabalho.Size = new Size(86, 30);
            btn_limpa_trabalho.TabIndex = 50;
            btn_limpa_trabalho.Text = "Limpar";
            btn_limpa_trabalho.UseVisualStyleBackColor = true;
            btn_limpa_trabalho.Click += btn_limpa_trabalho_Click;
            // 
            // btn_salva_trabalho
            // 
            btn_salva_trabalho.Enabled = false;
            btn_salva_trabalho.Location = new Point(929, 252);
            btn_salva_trabalho.Margin = new Padding(3, 4, 3, 4);
            btn_salva_trabalho.Name = "btn_salva_trabalho";
            btn_salva_trabalho.Size = new Size(86, 30);
            btn_salva_trabalho.TabIndex = 49;
            btn_salva_trabalho.Text = "Salvar";
            btn_salva_trabalho.UseVisualStyleBackColor = true;
            btn_salva_trabalho.Click += btn_salva_trabalho_Click;
            // 
            // txtMostraFunc
            // 
            txtMostraFunc.Enabled = false;
            txtMostraFunc.Location = new Point(833, 219);
            txtMostraFunc.Margin = new Padding(3, 4, 3, 4);
            txtMostraFunc.Name = "txtMostraFunc";
            txtMostraFunc.Size = new Size(85, 27);
            txtMostraFunc.TabIndex = 51;
            // 
            // txtMostraPeca
            // 
            txtMostraPeca.Enabled = false;
            txtMostraPeca.Location = new Point(929, 219);
            txtMostraPeca.Margin = new Padding(3, 4, 3, 4);
            txtMostraPeca.Name = "txtMostraPeca";
            txtMostraPeca.Size = new Size(85, 27);
            txtMostraPeca.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(833, 198);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 53;
            label5.Text = "Funcionario";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(929, 198);
            label14.Name = "label14";
            label14.Size = new Size(40, 17);
            label14.TabIndex = 54;
            label14.Text = "Peça";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(929, 462);
            label15.Name = "label15";
            label15.Size = new Size(65, 17);
            label15.TabIndex = 68;
            label15.Text = "Trabalho";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(833, 462);
            label16.Name = "label16";
            label16.Size = new Size(54, 17);
            label16.TabIndex = 67;
            label16.Text = "Veiculo";
            // 
            // txtMostraTrab
            // 
            txtMostraTrab.Enabled = false;
            txtMostraTrab.Location = new Point(929, 483);
            txtMostraTrab.Margin = new Padding(3, 4, 3, 4);
            txtMostraTrab.Name = "txtMostraTrab";
            txtMostraTrab.Size = new Size(85, 27);
            txtMostraTrab.TabIndex = 66;
            // 
            // txtMostraVeic
            // 
            txtMostraVeic.Enabled = false;
            txtMostraVeic.Location = new Point(833, 483);
            txtMostraVeic.Margin = new Padding(3, 4, 3, 4);
            txtMostraVeic.Name = "txtMostraVeic";
            txtMostraVeic.Size = new Size(85, 27);
            txtMostraVeic.TabIndex = 65;
            // 
            // button4
            // 
            button4.Location = new Point(833, 516);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 30);
            button4.TabIndex = 64;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = true;
            // 
            // btn_salva_reparo
            // 
            btn_salva_reparo.Enabled = false;
            btn_salva_reparo.Location = new Point(929, 516);
            btn_salva_reparo.Margin = new Padding(3, 4, 3, 4);
            btn_salva_reparo.Name = "btn_salva_reparo";
            btn_salva_reparo.Size = new Size(86, 30);
            btn_salva_reparo.TabIndex = 63;
            btn_salva_reparo.Text = "Salvar";
            btn_salva_reparo.UseVisualStyleBackColor = true;
            btn_salva_reparo.Click += btn_salva_reparo_Click;
            // 
            // lista_reparos
            // 
            lista_reparos.ContextMenuStrip = contextMenuStrip5;
            lista_reparos.Location = new Point(1040, 406);
            lista_reparos.Margin = new Padding(3, 4, 3, 4);
            lista_reparos.MultiSelect = false;
            lista_reparos.Name = "lista_reparos";
            lista_reparos.Size = new Size(565, 314);
            lista_reparos.TabIndex = 62;
            lista_reparos.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip5
            // 
            contextMenuStrip5.ImageScalingSize = new Size(24, 24);
            contextMenuStrip5.Items.AddRange(new ToolStripItem[] { toolStripMenuItem5 });
            contextMenuStrip5.Name = "contextMenuStrip1";
            contextMenuStrip5.Size = new Size(122, 28);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(121, 24);
            toolStripMenuItem5.Text = "Excluir";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // btn_busca_reparo
            // 
            btn_busca_reparo.Location = new Point(1519, 361);
            btn_busca_reparo.Margin = new Padding(3, 4, 3, 4);
            btn_busca_reparo.Name = "btn_busca_reparo";
            btn_busca_reparo.Size = new Size(86, 30);
            btn_busca_reparo.TabIndex = 61;
            btn_busca_reparo.Text = "Buscar";
            btn_busca_reparo.UseVisualStyleBackColor = true;
            // 
            // txtBuscaReparo
            // 
            txtBuscaReparo.Location = new Point(1040, 361);
            txtBuscaReparo.Margin = new Padding(3, 4, 3, 4);
            txtBuscaReparo.Name = "txtBuscaReparo";
            txtBuscaReparo.Size = new Size(471, 27);
            txtBuscaReparo.TabIndex = 60;
            // 
            // txtReparoCustoTotal
            // 
            txtReparoCustoTotal.Location = new Point(834, 423);
            txtReparoCustoTotal.Margin = new Padding(3, 4, 3, 4);
            txtReparoCustoTotal.Name = "txtReparoCustoTotal";
            txtReparoCustoTotal.Size = new Size(181, 27);
            txtReparoCustoTotal.TabIndex = 59;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(1040, 339);
            label17.Name = "label17";
            label17.Size = new Size(114, 17);
            label17.TabIndex = 57;
            label17.Text = "Buscar REPARO";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(834, 402);
            label18.Name = "label18";
            label18.Size = new Size(80, 17);
            label18.TabIndex = 56;
            label18.Text = "Custo Total";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(834, 339);
            label19.Name = "label19";
            label19.Size = new Size(104, 17);
            label19.TabIndex = 55;
            label19.Text = "Data do reparo";
            // 
            // dataReparo
            // 
            dataReparo.Format = DateTimePickerFormat.Short;
            dataReparo.Location = new Point(834, 362);
            dataReparo.Margin = new Padding(3, 4, 3, 4);
            dataReparo.Name = "dataReparo";
            dataReparo.Size = new Size(181, 27);
            dataReparo.TabIndex = 69;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 792);
            Controls.Add(dataReparo);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(txtMostraTrab);
            Controls.Add(txtMostraVeic);
            Controls.Add(button4);
            Controls.Add(btn_salva_reparo);
            Controls.Add(lista_reparos);
            Controls.Add(btn_busca_reparo);
            Controls.Add(txtBuscaReparo);
            Controls.Add(txtReparoCustoTotal);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label14);
            Controls.Add(label5);
            Controls.Add(txtMostraPeca);
            Controls.Add(txtMostraFunc);
            Controls.Add(btn_limpa_trabalho);
            Controls.Add(btn_salva_trabalho);
            Controls.Add(lista_trabalhos);
            Controls.Add(btn_busca_mao_de_obra);
            Controls.Add(txtBuscaMaoDeObra);
            Controls.Add(txtCusto);
            Controls.Add(txtTempo);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btn_busca_peca);
            Controls.Add(txtBuscaPeca);
            Controls.Add(label10);
            Controls.Add(btn_limpa_peca);
            Controls.Add(btn_salva_peca);
            Controls.Add(lista_pecas);
            Controls.Add(label9);
            Controls.Add(txtPecaArmaz);
            Controls.Add(label7);
            Controls.Add(txtPecaUnit);
            Controls.Add(label6);
            Controls.Add(txtPecaDesign);
            Controls.Add(txtVeiculo);
            Controls.Add(lista_veiculos);
            Controls.Add(btn_salva_veiculo);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(lista_pessoas);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(txtTelefone);
            Controls.Add(txtMorada);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Gerenciador de Veiculos";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            contextMenuStrip4.ResumeLayout(false);
            contextMenuStrip5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtMorada;
        private TextBox txtTelefone;
        private TextBox txtBuscar;
        private Button button1;
        private Button button2;
        private ListView lista_pessoas;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button button3;
        private Button btn_limpa_trabalho;
        private ListView listView1;
        private Button btn_salva_trabalho;
        private Button btn_salva_veiculo;
        private TextBox textBox1;
        private Label label5;
        private Label label8;
        private ListView lista_veiculos;
        private DateTimePicker txtVeiculo;
        private TextBox txtPecaDesign;
        private Label label6;
        private Label label7;
        private TextBox txtPecaUnit;
        private Label label9;
        private TextBox txtPecaArmaz;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ListView lista_pecas;
        private Button btn_limpa_peca;
        private Button btn_salva_peca;
        private Button btn_busca_peca;
        private TextBox txtBuscaPeca;
        private Label label10;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem toolStripMenuItem3;
        private ListView lista_trabalhos;
        private Button btn_busca_mao_de_obra;
        private TextBox txtBuscaMaoDeObra;
        private TextBox txtCusto;
        private TextBox txtTempo;
        private Label label11;
        private Label label12;
        private Label label13;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem toolStripMenuItem4;
        private TextBox txtMostraFunc;
        private TextBox txtMostraPeca;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtMostraTrab;
        private TextBox txtMostraVeic;
        private Button button4;
        private Button btn_salva_reparo;
        private ListView lista_reparos;
        private ContextMenuStrip contextMenuStrip5;
        private ToolStripMenuItem toolStripMenuItem5;
        private Button btn_busca_reparo;
        private TextBox txtBuscaReparo;
        private TextBox txtReparoCustoTotal;
        private Label label17;
        private Label label18;
        private Label label19;
        private DateTimePicker dataReparo;
    }
}