namespace Prova2Talles
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.lbQtdAssentos = new System.Windows.Forms.Label();
            this.tbQtdAssentos = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbQtdEixos = new System.Windows.Forms.Label();
            this.tbQtdEixos = new System.Windows.Forms.TextBox();
            this.pbCaminhao = new System.Windows.Forms.PictureBox();
            this.pbOnibus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnibus)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ônibus";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(171, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Caminhão";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(129, 114);
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(100, 22);
            this.mtbPlaca.TabIndex = 2;
            this.mtbPlaca.Text = "___-____";
            this.mtbPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPlaca_MaskInputRejected);
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(45, 117);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 3;
            this.lbPlaca.Text = "Placa";
            this.lbPlaca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(45, 161);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(31, 16);
            this.lbAno.TabIndex = 4;
            this.lbAno.Text = "Ano";
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(129, 161);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 22);
            this.tbAno.TabIndex = 5;
            // 
            // lbQtdAssentos
            // 
            this.lbQtdAssentos.AutoSize = true;
            this.lbQtdAssentos.Location = new System.Drawing.Point(36, 207);
            this.lbQtdAssentos.Name = "lbQtdAssentos";
            this.lbQtdAssentos.Size = new System.Drawing.Size(87, 16);
            this.lbQtdAssentos.TabIndex = 6;
            this.lbQtdAssentos.Text = "Qtd Assentos";
            // 
            // tbQtdAssentos
            // 
            this.tbQtdAssentos.Location = new System.Drawing.Point(129, 207);
            this.tbQtdAssentos.Name = "tbQtdAssentos";
            this.tbQtdAssentos.Size = new System.Drawing.Size(100, 22);
            this.tbQtdAssentos.TabIndex = 7;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(28, 251);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 46);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(129, 251);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(80, 46);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click_1);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 332);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 106);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbQtdEixos
            // 
            this.lbQtdEixos.AutoSize = true;
            this.lbQtdEixos.Location = new System.Drawing.Point(36, 207);
            this.lbQtdEixos.Name = "lbQtdEixos";
            this.lbQtdEixos.Size = new System.Drawing.Size(64, 16);
            this.lbQtdEixos.TabIndex = 12;
            this.lbQtdEixos.Text = "Qtd Eixos";
            // 
            // tbQtdEixos
            // 
            this.tbQtdEixos.Location = new System.Drawing.Point(129, 207);
            this.tbQtdEixos.Name = "tbQtdEixos";
            this.tbQtdEixos.Size = new System.Drawing.Size(100, 22);
            this.tbQtdEixos.TabIndex = 13;
            // 
            // pbCaminhao
            // 
            this.pbCaminhao.Image = global::Prova2Talles.Properties.Resources.caminhao;
            this.pbCaminhao.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCaminhao.InitialImage")));
            this.pbCaminhao.Location = new System.Drawing.Point(395, 12);
            this.pbCaminhao.Name = "pbCaminhao";
            this.pbCaminhao.Size = new System.Drawing.Size(346, 314);
            this.pbCaminhao.TabIndex = 14;
            this.pbCaminhao.TabStop = false;
            // 
            // pbOnibus
            // 
            this.pbOnibus.Image = global::Prova2Talles.Properties.Resources.onibuzin;
            this.pbOnibus.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbOnibus.InitialImage")));
            this.pbOnibus.Location = new System.Drawing.Point(395, 12);
            this.pbOnibus.Name = "pbOnibus";
            this.pbOnibus.Size = new System.Drawing.Size(346, 314);
            this.pbOnibus.TabIndex = 11;
            this.pbOnibus.TabStop = false;
            this.pbOnibus.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCaminhao);
            this.Controls.Add(this.tbQtdEixos);
            this.Controls.Add(this.lbQtdEixos);
            this.Controls.Add(this.pbOnibus);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbQtdAssentos);
            this.Controls.Add(this.lbQtdAssentos);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnibus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label lbQtdAssentos;
        private System.Windows.Forms.TextBox tbQtdAssentos;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pbOnibus;
        private System.Windows.Forms.Label lbQtdEixos;
        private System.Windows.Forms.TextBox tbQtdEixos;
        private System.Windows.Forms.PictureBox pbCaminhao;
    }
}

