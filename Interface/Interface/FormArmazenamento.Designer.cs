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
            this.btnSalvarBanco = new System.Windows.Forms.Button();
            this.pnlOpcoesArmazenamento = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.btnSalvarExtras = new System.Windows.Forms.Button();
            this.txtExperimento = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbSalvarResultadosExcel = new System.Windows.Forms.CheckBox();
            this.chbSalvarImagensPC = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fbdResultados = new System.Windows.Forms.FolderBrowserDialog();
            this.ttDescSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.lblBanco = new System.Windows.Forms.Label();
            this.pnlOpcoesArmazenamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarBanco
            // 
            this.btnSalvarBanco.Location = new System.Drawing.Point(261, 57);
            this.btnSalvarBanco.Name = "btnSalvarBanco";
            this.btnSalvarBanco.Size = new System.Drawing.Size(69, 47);
            this.btnSalvarBanco.TabIndex = 90;
            this.btnSalvarBanco.Text = "Salvar";
            this.btnSalvarBanco.UseVisualStyleBackColor = true;
            this.btnSalvarBanco.Click += new System.EventHandler(this.BtnSalvarBanco_Click);
            // 
            // pnlOpcoesArmazenamento
            // 
            this.pnlOpcoesArmazenamento.Controls.Add(this.lblBanco);
            this.pnlOpcoesArmazenamento.Controls.Add(this.label4);
            this.pnlOpcoesArmazenamento.Controls.Add(this.txtNomeArquivo);
            this.pnlOpcoesArmazenamento.Controls.Add(this.btnSalvarExtras);
            this.pnlOpcoesArmazenamento.Controls.Add(this.btnSalvarBanco);
            this.pnlOpcoesArmazenamento.Controls.Add(this.txtExperimento);
            this.pnlOpcoesArmazenamento.Controls.Add(this.label2);
            this.pnlOpcoesArmazenamento.Controls.Add(this.label1);
            this.pnlOpcoesArmazenamento.Controls.Add(this.txtAutor);
            this.pnlOpcoesArmazenamento.Controls.Add(this.label9);
            this.pnlOpcoesArmazenamento.Controls.Add(this.chbSalvarResultadosExcel);
            this.pnlOpcoesArmazenamento.Controls.Add(this.chbSalvarImagensPC);
            this.pnlOpcoesArmazenamento.Location = new System.Drawing.Point(5, 19);
            this.pnlOpcoesArmazenamento.Name = "pnlOpcoesArmazenamento";
            this.pnlOpcoesArmazenamento.Size = new System.Drawing.Size(333, 210);
            this.pnlOpcoesArmazenamento.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Nome do Arquivo:";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(105, 130);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(219, 20);
            this.txtNomeArquivo.TabIndex = 100;
            // 
            // btnSalvarExtras
            // 
            this.btnSalvarExtras.Location = new System.Drawing.Point(261, 154);
            this.btnSalvarExtras.Name = "btnSalvarExtras";
            this.btnSalvarExtras.Size = new System.Drawing.Size(63, 47);
            this.btnSalvarExtras.TabIndex = 99;
            this.btnSalvarExtras.Text = "Salvar";
            this.btnSalvarExtras.UseVisualStyleBackColor = true;
            this.btnSalvarExtras.Click += new System.EventHandler(this.BtnSalvarExtras_Click);
            // 
            // txtExperimento
            // 
            this.txtExperimento.Location = new System.Drawing.Point(7, 57);
            this.txtExperimento.Name = "txtExperimento";
            this.txtExperimento.Size = new System.Drawing.Size(248, 47);
            this.txtExperimento.TabIndex = 97;
            this.txtExperimento.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Experimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(10, 18);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(320, 20);
            this.txtAutor.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "Extras:";
            // 
            // chbSalvarResultadosExcel
            // 
            this.chbSalvarResultadosExcel.AutoSize = true;
            this.chbSalvarResultadosExcel.Location = new System.Drawing.Point(7, 158);
            this.chbSalvarResultadosExcel.Name = "chbSalvarResultadosExcel";
            this.chbSalvarResultadosExcel.Size = new System.Drawing.Size(246, 17);
            this.chbSalvarResultadosExcel.TabIndex = 88;
            this.chbSalvarResultadosExcel.Text = "Salvar resultados em planilha do Excel.        (?)";
            this.ttDescSalvar.SetToolTip(this.chbSalvarResultadosExcel, "As informações gerais da análise serão convertidas em uma planilha do excel, \r\nqu" +
        "e será salva em uma pasta especificada pelo usuário. \r\n");
            this.chbSalvarResultadosExcel.UseVisualStyleBackColor = true;
            // 
            // chbSalvarImagensPC
            // 
            this.chbSalvarImagensPC.AutoSize = true;
            this.chbSalvarImagensPC.Location = new System.Drawing.Point(7, 184);
            this.chbSalvarImagensPC.Name = "chbSalvarImagensPC";
            this.chbSalvarImagensPC.Size = new System.Drawing.Size(246, 17);
            this.chbSalvarImagensPC.TabIndex = 87;
            this.chbSalvarImagensPC.Text = "Salvar capturas no computador                    (?)";
            this.ttDescSalvar.SetToolTip(this.chbSalvarImagensPC, "As imagens da análise serão salvas em uma pasta especificada pelo usuário. ");
            this.chbSalvarImagensPC.UseMnemonic = false;
            this.chbSalvarImagensPC.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Opções de Armazenamento";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(258, 107);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(35, 13);
            this.lblBanco.TabIndex = 102;
            this.lblBanco.Text = "label3";
            // 
            // FormArmazenamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 230);
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

        private System.Windows.Forms.Button btnSalvarBanco;
        private System.Windows.Forms.Panel pnlOpcoesArmazenamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbSalvarResultadosExcel;
        private System.Windows.Forms.CheckBox chbSalvarImagensPC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog fbdResultados;
        private System.Windows.Forms.ToolTip ttDescSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.RichTextBox txtExperimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarExtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lblBanco;
    }
}