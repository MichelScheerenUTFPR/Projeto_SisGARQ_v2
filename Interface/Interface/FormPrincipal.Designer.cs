namespace Interface
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pnlWebCam = new System.Windows.Forms.Panel();
            this.pnlAnalise = new System.Windows.Forms.Panel();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregarDiferenciador = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIniciarCapturas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnObterDiferenciador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCapturas = new System.Windows.Forms.NumericUpDown();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.pnlArmazenamento = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnVerHistorico = new System.Windows.Forms.Button();
            this.cpbCapturas = new CircularProgressBar.CircularProgressBar();
            this.pnlAnalise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWebCam
            // 
            this.pnlWebCam.Location = new System.Drawing.Point(12, 15);
            this.pnlWebCam.Name = "pnlWebCam";
            this.pnlWebCam.Size = new System.Drawing.Size(654, 440);
            this.pnlWebCam.TabIndex = 0;
            // 
            // pnlAnalise
            // 
            this.pnlAnalise.Controls.Add(this.cpbCapturas);
            this.pnlAnalise.Controls.Add(this.txtBlue);
            this.pnlAnalise.Controls.Add(this.label1);
            this.pnlAnalise.Controls.Add(this.btnCarregarDiferenciador);
            this.pnlAnalise.Controls.Add(this.label6);
            this.pnlAnalise.Controls.Add(this.btnIniciarCapturas);
            this.pnlAnalise.Controls.Add(this.label5);
            this.pnlAnalise.Controls.Add(this.btnObterDiferenciador);
            this.pnlAnalise.Controls.Add(this.label3);
            this.pnlAnalise.Controls.Add(this.label4);
            this.pnlAnalise.Controls.Add(this.nudCapturas);
            this.pnlAnalise.Controls.Add(this.txtGreen);
            this.pnlAnalise.Controls.Add(this.nudTempo);
            this.pnlAnalise.Controls.Add(this.label2);
            this.pnlAnalise.Controls.Add(this.txtRed);
            this.pnlAnalise.Location = new System.Drawing.Point(12, 461);
            this.pnlAnalise.Name = "pnlAnalise";
            this.pnlAnalise.Size = new System.Drawing.Size(307, 228);
            this.pnlAnalise.TabIndex = 1;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(45, 203);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(155, 20);
            this.txtBlue.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Blue";
            // 
            // btnCarregarDiferenciador
            // 
            this.btnCarregarDiferenciador.Location = new System.Drawing.Point(3, 18);
            this.btnCarregarDiferenciador.Name = "btnCarregarDiferenciador";
            this.btnCarregarDiferenciador.Size = new System.Drawing.Size(140, 46);
            this.btnCarregarDiferenciador.TabIndex = 113;
            this.btnCarregarDiferenciador.Text = "Abrir imagem do Diferenciador";
            this.btnCarregarDiferenciador.UseVisualStyleBackColor = true;
            this.btnCarregarDiferenciador.Click += new System.EventHandler(this.BtnCarregarDiferenciador_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 111;
            this.label6.Text = "Opções de Análise";
            // 
            // btnIniciarCapturas
            // 
            this.btnIniciarCapturas.Enabled = false;
            this.btnIniciarCapturas.Location = new System.Drawing.Point(157, 70);
            this.btnIniciarCapturas.Name = "btnIniciarCapturas";
            this.btnIniciarCapturas.Size = new System.Drawing.Size(147, 46);
            this.btnIniciarCapturas.TabIndex = 109;
            this.btnIniciarCapturas.Text = "Iniciar Análise";
            this.btnIniciarCapturas.UseVisualStyleBackColor = true;
            this.btnIniciarCapturas.Click += new System.EventHandler(this.BtnIniciarCapturas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Capturas/seg";
            // 
            // btnObterDiferenciador
            // 
            this.btnObterDiferenciador.Location = new System.Drawing.Point(3, 70);
            this.btnObterDiferenciador.Name = "btnObterDiferenciador";
            this.btnObterDiferenciador.Size = new System.Drawing.Size(140, 46);
            this.btnObterDiferenciador.TabIndex = 98;
            this.btnObterDiferenciador.Text = "Obter Direrenciador";
            this.btnObterDiferenciador.UseVisualStyleBackColor = true;
            this.btnObterDiferenciador.Click += new System.EventHandler(this.BtnObterDiferenciador_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Tempo (seg)";
            // 
            // nudCapturas
            // 
            this.nudCapturas.Location = new System.Drawing.Point(231, 44);
            this.nudCapturas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapturas.Name = "nudCapturas";
            this.nudCapturas.Size = new System.Drawing.Size(73, 20);
            this.nudCapturas.TabIndex = 107;
            this.nudCapturas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(45, 171);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(155, 20);
            this.txtGreen.TabIndex = 103;
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(231, 18);
            this.nudTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(73, 20);
            this.nudTempo.TabIndex = 105;
            this.nudTempo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Red";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(45, 135);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(155, 20);
            this.txtRed.TabIndex = 101;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(672, 15);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(680, 640);
            this.pnlGrafico.TabIndex = 2;
            // 
            // pnlArmazenamento
            // 
            this.pnlArmazenamento.Location = new System.Drawing.Point(325, 461);
            this.pnlArmazenamento.Name = "pnlArmazenamento";
            this.pnlArmazenamento.Size = new System.Drawing.Size(341, 230);
            this.pnlArmazenamento.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnVerHistorico
            // 
            this.btnVerHistorico.Location = new System.Drawing.Point(1196, 662);
            this.btnVerHistorico.Name = "btnVerHistorico";
            this.btnVerHistorico.Size = new System.Drawing.Size(156, 29);
            this.btnVerHistorico.TabIndex = 4;
            this.btnVerHistorico.Text = "Ver Histórico de Análises";
            this.btnVerHistorico.UseVisualStyleBackColor = true;
            this.btnVerHistorico.Click += new System.EventHandler(this.BtnVerHistorico_Click);
            // 
            // cpbCapturas
            // 
            this.cpbCapturas.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCapturas.AnimationSpeed = 1500;
            this.cpbCapturas.BackColor = System.Drawing.Color.Transparent;
            this.cpbCapturas.Enabled = false;
            this.cpbCapturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbCapturas.ForeColor = System.Drawing.Color.Black;
            this.cpbCapturas.InnerColor = System.Drawing.Color.White;
            this.cpbCapturas.InnerMargin = 2;
            this.cpbCapturas.InnerWidth = -1;
            this.cpbCapturas.Location = new System.Drawing.Point(224, 135);
            this.cpbCapturas.MarqueeAnimationSpeed = 1500;
            this.cpbCapturas.Name = "cpbCapturas";
            this.cpbCapturas.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cpbCapturas.OuterMargin = -10;
            this.cpbCapturas.OuterWidth = 10;
            this.cpbCapturas.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbCapturas.ProgressWidth = 10;
            this.cpbCapturas.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbCapturas.Size = new System.Drawing.Size(80, 80);
            this.cpbCapturas.StartAngle = 270;
            this.cpbCapturas.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbCapturas.SubscriptColor = System.Drawing.Color.White;
            this.cpbCapturas.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbCapturas.SubscriptText = ".23";
            this.cpbCapturas.SuperscriptColor = System.Drawing.Color.White;
            this.cpbCapturas.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbCapturas.SuperscriptText = "°C";
            this.cpbCapturas.TabIndex = 0;
            this.cpbCapturas.Text = "Aguarde...";
            this.cpbCapturas.TextMargin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.cpbCapturas.Value = 70;
            this.cpbCapturas.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.btnVerHistorico);
            this.Controls.Add(this.pnlArmazenamento);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.pnlAnalise);
            this.Controls.Add(this.pnlWebCam);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.pnlAnalise.ResumeLayout(false);
            this.pnlAnalise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWebCam;
        private System.Windows.Forms.Panel pnlAnalise;
        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Panel pnlArmazenamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIniciarCapturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnObterDiferenciador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCapturas;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCarregarDiferenciador;
        private System.Windows.Forms.Button btnVerHistorico;
        private CircularProgressBar.CircularProgressBar cpbCapturas;
    }
}

