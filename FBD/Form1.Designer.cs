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
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            contextMenuStrip4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 56);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 103);
            label2.Name = "label2";
            label2.Size = new Size(43, 13);
            label2.TabIndex = 1;
            label2.Text = "Morada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 13);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(209, 56);
            label4.Name = "label4";
            label4.Size = new Size(131, 13);
            label4.TabIndex = 3;
            label4.Text = "Buscar cliente/funcionário";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(29, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(159, 23);
            txtNome.TabIndex = 4;
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(29, 119);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(159, 23);
            txtMorada.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(29, 170);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(159, 23);
            txtTelefone.TabIndex = 6;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(209, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(413, 23);
            txtBuscar.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(113, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(628, 72);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lista_pessoas
            // 
            lista_pessoas.ContextMenuStrip = contextMenuStrip1;
            lista_pessoas.ImeMode = ImeMode.NoControl;
            lista_pessoas.Location = new Point(209, 106);
            lista_pessoas.MultiSelect = false;
            lista_pessoas.Name = "lista_pessoas";
            lista_pessoas.Size = new Size(495, 116);
            lista_pessoas.TabIndex = 10;
            lista_pessoas.UseCompatibleStateImageBehavior = false;
            lista_pessoas.ItemSelectionChanged += lista_pessoas_ItemSelectionChanged;
            lista_pessoas.SelectedIndexChanged += lista_pessoas_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(109, 22);
            toolStripMenuItem1.Text = "Excluir";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 19);
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
            comboBox1.Location = new Point(128, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Selecione uma categoria";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(29, 199);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Limpar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_salva_veiculo
            // 
            btn_salva_veiculo.Enabled = false;
            btn_salva_veiculo.Location = new Point(113, 294);
            btn_salva_veiculo.Name = "btn_salva_veiculo";
            btn_salva_veiculo.Size = new Size(75, 23);
            btn_salva_veiculo.TabIndex = 22;
            btn_salva_veiculo.Text = "Salvar";
            btn_salva_veiculo.UseVisualStyleBackColor = true;
            btn_salva_veiculo.Click += btn_salva_veiculo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(29, 244);
            label8.Name = "label8";
            label8.Size = new Size(145, 13);
            label8.TabIndex = 14;
            label8.Text = "Data de aquisicao do veiculo";
            // 
            // lista_veiculos
            // 
            lista_veiculos.ContextMenuStrip = contextMenuStrip2;
            lista_veiculos.Location = new Point(209, 255);
            lista_veiculos.Name = "lista_veiculos";
            lista_veiculos.Size = new Size(495, 97);
            lista_veiculos.TabIndex = 26;
            lista_veiculos.UseCompatibleStateImageBehavior = false;
            lista_veiculos.ItemSelectionChanged += lista_veiculos_ItemSelectionChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(110, 26);
            contextMenuStrip2.Click += contextMenuStrip2_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(109, 22);
            toolStripMenuItem2.Text = "Excluir";
            // 
            // txtVeiculo
            // 
            txtVeiculo.Format = DateTimePickerFormat.Short;
            txtVeiculo.Location = new Point(29, 265);
            txtVeiculo.Name = "txtVeiculo";
            txtVeiculo.Size = new Size(159, 23);
            txtVeiculo.TabIndex = 27;
            // 
            // txtPecaDesign
            // 
            txtPecaDesign.Location = new Point(29, 387);
            txtPecaDesign.Name = "txtPecaDesign";
            txtPecaDesign.Size = new Size(159, 23);
            txtPecaDesign.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 371);
            label6.Name = "label6";
            label6.Size = new Size(64, 13);
            label6.TabIndex = 29;
            label6.Text = "Designação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 415);
            label7.Name = "label7";
            label7.Size = new Size(71, 13);
            label7.TabIndex = 31;
            label7.Text = "Custo unitário";
            // 
            // txtPecaUnit
            // 
            txtPecaUnit.Location = new Point(29, 431);
            txtPecaUnit.Name = "txtPecaUnit";
            txtPecaUnit.Size = new Size(159, 23);
            txtPecaUnit.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(29, 459);
            label9.Name = "label9";
            label9.Size = new Size(107, 13);
            label9.TabIndex = 33;
            label9.Text = "Quantidade armazem";
            // 
            // txtPecaArmaz
            // 
            txtPecaArmaz.Location = new Point(29, 475);
            txtPecaArmaz.Name = "txtPecaArmaz";
            txtPecaArmaz.Size = new Size(159, 23);
            txtPecaArmaz.TabIndex = 32;
            // 
            // lista_pecas
            // 
            lista_pecas.ContextMenuStrip = contextMenuStrip3;
            lista_pecas.Location = new Point(208, 415);
            lista_pecas.Name = "lista_pecas";
            lista_pecas.Size = new Size(495, 126);
            lista_pecas.TabIndex = 34;
            lista_pecas.UseCompatibleStateImageBehavior = false;
            lista_pecas.ItemSelectionChanged += lista_pecas_ItemSelectionChanged;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            contextMenuStrip3.Name = "contextMenuStrip1";
            contextMenuStrip3.Size = new Size(110, 26);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(109, 22);
            toolStripMenuItem3.Text = "Excluir";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // btn_limpa_peca
            // 
            btn_limpa_peca.Location = new Point(29, 509);
            btn_limpa_peca.Name = "btn_limpa_peca";
            btn_limpa_peca.Size = new Size(75, 23);
            btn_limpa_peca.TabIndex = 36;
            btn_limpa_peca.Text = "Limpar";
            btn_limpa_peca.UseVisualStyleBackColor = true;
            btn_limpa_peca.Click += btn_limpa_peca_Click;
            // 
            // btn_salva_peca
            // 
            btn_salva_peca.Location = new Point(113, 509);
            btn_salva_peca.Name = "btn_salva_peca";
            btn_salva_peca.Size = new Size(75, 23);
            btn_salva_peca.TabIndex = 35;
            btn_salva_peca.Text = "Salvar";
            btn_salva_peca.UseVisualStyleBackColor = true;
            btn_salva_peca.Click += btn_salva_peca_Click;
            // 
            // btn_busca_peca
            // 
            btn_busca_peca.Location = new Point(627, 386);
            btn_busca_peca.Name = "btn_busca_peca";
            btn_busca_peca.Size = new Size(75, 23);
            btn_busca_peca.TabIndex = 39;
            btn_busca_peca.Text = "Buscar";
            btn_busca_peca.UseVisualStyleBackColor = true;
            btn_busca_peca.Click += btn_busca_peca_Click;
            // 
            // txtBuscaPeca
            // 
            txtBuscaPeca.Location = new Point(208, 386);
            txtBuscaPeca.Name = "txtBuscaPeca";
            txtBuscaPeca.Size = new Size(413, 23);
            txtBuscaPeca.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(208, 370);
            label10.Name = "label10";
            label10.Size = new Size(67, 13);
            label10.TabIndex = 37;
            label10.Text = "Buscar peça";
            // 
            // lista_trabalhos
            // 
            lista_trabalhos.ContextMenuStrip = contextMenuStrip4;
            lista_trabalhos.Location = new Point(910, 106);
            lista_trabalhos.MultiSelect = false;
            lista_trabalhos.Name = "lista_trabalhos";
            lista_trabalhos.Size = new Size(495, 116);
            lista_trabalhos.TabIndex = 47;
            lista_trabalhos.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            contextMenuStrip4.Name = "contextMenuStrip1";
            contextMenuStrip4.Size = new Size(110, 26);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(109, 22);
            toolStripMenuItem4.Text = "Excluir";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // btn_busca_mao_de_obra
            // 
            btn_busca_mao_de_obra.Location = new Point(1329, 72);
            btn_busca_mao_de_obra.Name = "btn_busca_mao_de_obra";
            btn_busca_mao_de_obra.Size = new Size(75, 23);
            btn_busca_mao_de_obra.TabIndex = 46;
            btn_busca_mao_de_obra.Text = "Buscar";
            btn_busca_mao_de_obra.UseVisualStyleBackColor = true;
            btn_busca_mao_de_obra.Click += btn_busca_mao_de_obra_Click;
            // 
            // txtBuscaMaoDeObra
            // 
            txtBuscaMaoDeObra.Location = new Point(910, 72);
            txtBuscaMaoDeObra.Name = "txtBuscaMaoDeObra";
            txtBuscaMaoDeObra.Size = new Size(413, 23);
            txtBuscaMaoDeObra.TabIndex = 45;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(730, 119);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(159, 23);
            txtCusto.TabIndex = 44;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(730, 72);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(159, 23);
            txtTempo.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(910, 56);
            label11.Name = "label11";
            label11.Size = new Size(81, 13);
            label11.TabIndex = 42;
            label11.Text = "Buscar trabalho";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(730, 103);
            label12.Name = "label12";
            label12.Size = new Size(34, 13);
            label12.TabIndex = 41;
            label12.Text = "Custo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(730, 56);
            label13.Name = "label13";
            label13.Size = new Size(40, 13);
            label13.TabIndex = 40;
            label13.Text = "Tempo";
            // 
            // btn_limpa_trabalho
            // 
            btn_limpa_trabalho.Location = new Point(730, 148);
            btn_limpa_trabalho.Name = "btn_limpa_trabalho";
            btn_limpa_trabalho.Size = new Size(75, 23);
            btn_limpa_trabalho.TabIndex = 50;
            btn_limpa_trabalho.Text = "Limpar";
            btn_limpa_trabalho.UseVisualStyleBackColor = true;
            btn_limpa_trabalho.Click += btn_limpa_trabalho_Click;
            // 
            // btn_salva_trabalho
            // 
            btn_salva_trabalho.Enabled = false;
            btn_salva_trabalho.Location = new Point(814, 148);
            btn_salva_trabalho.Name = "btn_salva_trabalho";
            btn_salva_trabalho.Size = new Size(75, 23);
            btn_salva_trabalho.TabIndex = 49;
            btn_salva_trabalho.Text = "Salvar";
            btn_salva_trabalho.UseVisualStyleBackColor = true;
            btn_salva_trabalho.Click += btn_salva_trabalho_Click;
            // 
            // txtMostraFunc
            // 
            txtMostraFunc.Enabled = false;
            txtMostraFunc.Location = new Point(730, 199);
            txtMostraFunc.Name = "txtMostraFunc";
            txtMostraFunc.Size = new Size(75, 23);
            txtMostraFunc.TabIndex = 51;
            // 
            // txtMostraPeca
            // 
            txtMostraPeca.Enabled = false;
            txtMostraPeca.Location = new Point(814, 199);
            txtMostraPeca.Name = "txtMostraPeca";
            txtMostraPeca.Size = new Size(75, 23);
            txtMostraPeca.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(730, 183);
            label5.Name = "label5";
            label5.Size = new Size(62, 13);
            label5.TabIndex = 53;
            label5.Text = "Funcionario";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(814, 183);
            label14.Name = "label14";
            label14.Size = new Size(32, 13);
            label14.TabIndex = 54;
            label14.Text = "Peça";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 594);
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
            Name = "Form1";
            Text = "Gerenciador de Veiculos";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            contextMenuStrip4.ResumeLayout(false);
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
    }
}