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
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
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
            button1.Text = "Inserir";
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
            lista_pessoas.Location = new Point(209, 106);
            lista_pessoas.Name = "lista_pessoas";
            lista_pessoas.Size = new Size(495, 116);
            lista_pessoas.TabIndex = 10;
            lista_pessoas.UseCompatibleStateImageBehavior = false;
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
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 578);
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
    }
}