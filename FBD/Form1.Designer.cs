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
            txtVeiculo = new DateTimePicker();
            contextMenuStrip1.SuspendLayout();
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
            label4.Size = new Size(40, 13);
            label4.TabIndex = 3;
            label4.Text = "Buscar";
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
            lista_veiculos.Location = new Point(213, 255);
            lista_veiculos.Name = "lista_veiculos";
            lista_veiculos.Size = new Size(490, 97);
            lista_veiculos.TabIndex = 26;
            lista_veiculos.UseCompatibleStateImageBehavior = false;
            // 
            // txtVeiculo
            // 
            txtVeiculo.Format = DateTimePickerFormat.Short;
            txtVeiculo.Location = new Point(29, 265);
            txtVeiculo.Name = "txtVeiculo";
            txtVeiculo.Size = new Size(159, 23);
            txtVeiculo.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 578);
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
        private Button button4;
        private ListView listView1;
        private Button button5;
        private Button btn_salva_veiculo;
        private TextBox textBox1;
        private Label label5;
        private Label label8;
        private ListView lista_veiculos;
        private DateTimePicker txtVeiculo;
    }
}