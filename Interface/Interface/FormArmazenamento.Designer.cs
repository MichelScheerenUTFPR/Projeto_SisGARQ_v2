namespace Interface
{
    partial class FormArmazenamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnArmazenamento = new System.Windows.Forms.Button();
            this.pnlOpcoesArmazenamento = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chbSalvarResultadosExcel = new System.Windows.Forms.CheckBox();
            this.chbSalvarImagensPC = new System.Windows.Forms.CheckBox();
            this.chbSalvarImagensBanco = new System.Windows.Forms.CheckBox();
            this.chbSalvarResultadosBanco = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fbdResultados = new System.Windows.Forms.FolderBrowserDialog();
            this.ttDescSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.pnlOpcoesArmazenamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArmazenamento
            // 
            this.btnArmazenamento.Location = new System.Drawing.Point(17, 190);
            this.btnArmazenamento.Name = "btnArmazenamento";
            this.btnArmazenamento.Size = new System.Drawing.Size(240, 33);
            this.btnArmazenamento.TabIndex = 90;
            this.btnArmazenamento.Text = "Salvar";
            this.btnArmazenamento.UseVisualStyleBackColor = true;
            this.btnArmazenamento.Click += new System.EventHandler(this.BtnArmazenamento_Click);
            // 
            // pnlOpcoesArmazenamento
            // 
            this.pnlOpcoesArmazenamento.Controls.Add(this.label9);
            this.pnlOpcoesArmazenamento.Controls.Add(this.label8);
            this.pnlOpcoesArmazenamento.Controls.Add(this.chbSalvarResultadosExcel);
            this.pnlOpcoesArmazenamento.Controls.Add(this.chbSalvarImagensPC);
            this.pnlOpcoesArmazenamento.Controls.Add(this.chbSalvarImagensBanco);
            this.pnlOpcoesArmazenamento.Controls.Add(this.chbSalvarResultadosBanco);
            this.pnlOpcoesArmazenamento.Location = new System.Drawing.Point(17, 22);
            this.pnlOpcoesArmazenamento.Name = "pnlOpcoesArmazenamento";
            this.pnlOpcoesArmazenamento.Size = new System.Drawing.Size(240, 162);
            this.pnlOpcoesArmazenamento.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "No Computador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 89;
            this.label8.Text = "No Aplicativo:";
            // 
            // chbSalvarResultadosExcel
            // 
            this.chbSalvarResultadosExcel.AutoSize = true;
            this.chbSalvarResultadosExcel.Location = new System.Drawing.Point(3, 116);
            this.chbSalvarResultadosExcel.Name = "chbSalvarResultadosExcel";
            this.chbSalvarResultadosExcel.Size = new System.Drawing.Size(234, 17);
            this.chbSalvarResultadosExcel.TabIndex = 88;
            this.chbSalvarResultadosExcel.Text = "Salvar resultados em planilha do Excel.    (?)";
            this.ttDescSalvar.SetToolTip(this.chbSalvarResultadosExcel, "As informações gerais da análise serão convertidas em uma planilha do excel, \r\nqu" +
        "e será salva em uma pasta especificada pelo usuário. \r\n");
            this.chbSalvarResultadosExcel.UseVisualStyleBackColor = true;
            // 
            // chbSalvarImagensPC
            // 
            this.chbSalvarImagensPC.AutoSize = true;
            this.chbSalvarImagensPC.Location = new System.Drawing.Point(3, 138);
            this.chbSalvarImagensPC.Name = "chbSalvarImagensPC";
            this.chbSalvarImagensPC.Size = new System.Drawing.Size(234, 17);
            this.chbSalvarImagensPC.TabIndex = 87;
            this.chbSalvarImagensPC.Text = "Salvar imagens em uma pasta local.         (?)";
            this.ttDescSalvar.SetToolTip(this.chbSalvarImagensPC, "As imagens da análise serão salvas em uma pasta especificada pelo usuário. ");
            this.chbSalvarImagensPC.UseMnemonic = false;
            this.chbSalvarImagensPC.UseVisualStyleBackColor = true;
            // 
            // chbSalvarImagensBanco
            // 
            this.chbSalvarImagensBanco.AutoSize = true;
            this.chbSalvarImagensBanco.Location = new System.Drawing.Point(3, 46);
            this.chbSalvarImagensBanco.Name = "chbSalvarImagensBanco";
            this.chbSalvarImagensBanco.Size = new System.Drawing.Size(235, 17);
            this.chbSalvarImagensBanco.TabIndex = 86;
            this.chbSalvarImagensBanco.Text = "Salvar imagens no banco de dados.         (?)";
            this.ttDescSalvar.SetToolTip(this.chbSalvarImagensBanco, "As imagens da análise serão armazendas no banco de dados, \r\nficando disponíveis p" +
        "ara consultas futuras dentro do aplicativo.\r\n");
            this.chbSalvarImagensBanco.UseVisualStyleBackColor = true;
            // 
            // chbSalvarResultadosBanco
            // 
            this.chbSalvarResultadosBanco.AutoSize = true;
            this.chbSalvarResultadosBanco.Checked = true;
            this.chbSalvarResultadosBanco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSalvarResultadosBanco.Location = new System.Drawing.Point(3, 23);
            this.chbSalvarResultadosBanco.Name = "chbSalvarResultadosBanco";
            this.chbSalvarResultadosBanco.Size = new System.Drawing.Size(235, 17);
            this.chbSalvarResultadosBanco.TabIndex = 85;
            this.chbSalvarResultadosBanco.Text = "Salvar resultados no banco de dados.      (?)";
            this.ttDescSalvar.SetToolTip(this.chbSalvarResultadosBanco, "As informações gerais da análise serão armazendas no banco de dados, \r\nficando di" +
        "sponíveis para consultas futuras dentro do aplicativo.");
            this.chbSalvarResultadosBanco.UseMnemonic = false;
            this.chbSalvarResultadosBanco.UseVisualStyleBackColor = true;
            this.chbSalvarResultadosBanco.CheckedChanged += new System.EventHandler(this.ChbSalvarResultadosBanco_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 16);
            this.label7.TabIndex = 88;
            this.label7.Text = "Opções de Armazenamento";
            // 
            // FormArmazenamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 228);
            this.Controls.Add(this.btnArmazenamento);
            this.Controls.Add(this.pnlOpcoesArmazenamento);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArmazenamento";
            this.Text = "FormArmazenamento";
            this.Load += new System.EventHandler(this.FormArmazenamento_Load);
            this.pnlOpcoesArmazenamento.ResumeLayout(false);
            this.pnlOpcoesArmazenamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArmazenamento;
        private System.Windows.Forms.Panel pnlOpcoesArmazenamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbSalvarResultadosExcel;
        private System.Windows.Forms.CheckBox chbSalvarImagensPC;
        private System.Windows.Forms.CheckBox chbSalvarImagensBanco;
        private System.Windows.Forms.CheckBox chbSalvarResultadosBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog fbdResultados;
        private System.Windows.Forms.ToolTip ttDescSalvar;
    }
}