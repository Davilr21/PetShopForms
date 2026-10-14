namespace PetShopForms
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblIdade = new Label();
            txtIdade = new TextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnCadastrar = new Button();
            lstAnimais = new ListBox();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(81, 36);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ScrollBar;
            txtNome.Location = new Point(81, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(217, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(81, 91);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "Idade";
            lblIdade.Click += lblIdade_Click;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.ScrollBar;
            txtIdade.Location = new Point(81, 109);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(58, 23);
            txtIdade.TabIndex = 3;
            txtIdade.TextChanged += textBox1_TextChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(81, 147);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo";
            lblTipo.Click += lblTipo_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Cachorro", "Gato", "Passaro" });
            cmbTipo.Location = new Point(81, 165);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(81, 213);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lstAnimais
            // 
            lstAnimais.FormattingEnabled = true;
            lstAnimais.ItemHeight = 15;
            lstAnimais.Location = new Point(81, 265);
            lstAnimais.Name = "lstAnimais";
            lstAnimais.Size = new Size(120, 94);
            lstAnimais.TabIndex = 7;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(81, 382);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(lstAnimais);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtIdade);
            Controls.Add(lblIdade);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblIdade;
        private TextBox txtIdade;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Button btnCadastrar;
        private ListBox lstAnimais;
        private Button btnFechar;
    }
}
