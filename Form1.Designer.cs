
namespace Luis_Henrique_da_Silva
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.lbValorInscricao = new System.Windows.Forms.Label();
            this.textBoxValorInscricao = new System.Windows.Forms.TextBox();
            this.btGerarInscricao = new System.Windows.Forms.Button();
            this.btGerarFicha = new System.Windows.Forms.Button();
            this.btBlocoDeNotas = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(13, 69);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 19);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(69, 64);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(407, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategoria.Location = new System.Drawing.Point(13, 118);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(75, 19);
            this.lbCategoria.TabIndex = 3;
            this.lbCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbCategoria.Location = new System.Drawing.Point(95, 118);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbCategoria.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNao);
            this.groupBox1.Controls.Add(this.radioButtonSim);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(263, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Está desempregado?";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNao.Location = new System.Drawing.Point(112, 43);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(52, 21);
            this.radioButtonNao.TabIndex = 1;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSim.Location = new System.Drawing.Point(20, 42);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(50, 21);
            this.radioButtonSim.TabIndex = 0;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // lbValorInscricao
            // 
            this.lbValorInscricao.AutoSize = true;
            this.lbValorInscricao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbValorInscricao.Location = new System.Drawing.Point(13, 259);
            this.lbValorInscricao.Name = "lbValorInscricao";
            this.lbValorInscricao.Size = new System.Drawing.Size(163, 22);
            this.lbValorInscricao.TabIndex = 6;
            this.lbValorInscricao.Text = "Valor da inscrição:";
            // 
            // textBoxValorInscricao
            // 
            this.textBoxValorInscricao.Location = new System.Drawing.Point(183, 257);
            this.textBoxValorInscricao.Name = "textBoxValorInscricao";
            this.textBoxValorInscricao.Size = new System.Drawing.Size(100, 23);
            this.textBoxValorInscricao.TabIndex = 7;
            // 
            // btGerarInscricao
            // 
            this.btGerarInscricao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGerarInscricao.Location = new System.Drawing.Point(585, 158);
            this.btGerarInscricao.Name = "btGerarInscricao";
            this.btGerarInscricao.Size = new System.Drawing.Size(182, 60);
            this.btGerarInscricao.TabIndex = 8;
            this.btGerarInscricao.Text = "Gerar Inscrição";
            this.btGerarInscricao.UseVisualStyleBackColor = true;
            this.btGerarInscricao.Click += new System.EventHandler(this.btGerarInscricao_Click);
            // 
            // btGerarFicha
            // 
            this.btGerarFicha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGerarFicha.Location = new System.Drawing.Point(602, 237);
            this.btGerarFicha.Name = "btGerarFicha";
            this.btGerarFicha.Size = new System.Drawing.Size(150, 43);
            this.btGerarFicha.TabIndex = 9;
            this.btGerarFicha.Text = "Gerar Ficha";
            this.btGerarFicha.UseVisualStyleBackColor = true;
            this.btGerarFicha.Click += new System.EventHandler(this.btGerarFicha_Click);
            // 
            // btBlocoDeNotas
            // 
            this.btBlocoDeNotas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btBlocoDeNotas.Location = new System.Drawing.Point(585, 301);
            this.btBlocoDeNotas.Name = "btBlocoDeNotas";
            this.btBlocoDeNotas.Size = new System.Drawing.Size(182, 64);
            this.btBlocoDeNotas.TabIndex = 10;
            this.btBlocoDeNotas.Text = "Bloco de Notas";
            this.btBlocoDeNotas.UseVisualStyleBackColor = true;
            this.btBlocoDeNotas.Click += new System.EventHandler(this.btBlocoDeNotas_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSair.Location = new System.Drawing.Point(672, 394);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(105, 44);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btBlocoDeNotas);
            this.Controls.Add(this.btGerarFicha);
            this.Controls.Add(this.btGerarInscricao);
            this.Controls.Add(this.textBoxValorInscricao);
            this.Controls.Add(this.lbValorInscricao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label lbValorInscricao;
        private System.Windows.Forms.TextBox textBoxValorInscricao;
        private System.Windows.Forms.Button btGerarInscricao;
        private System.Windows.Forms.Button btGerarFicha;
        private System.Windows.Forms.Button btBlocoDeNotas;
        private System.Windows.Forms.Button btSair;
    }
}

