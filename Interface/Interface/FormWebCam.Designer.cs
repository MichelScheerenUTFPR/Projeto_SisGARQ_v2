namespace Interface
{
    partial class FormWebCam
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
            this.menuWebCam = new System.Windows.Forms.MenuStrip();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDesenhado = new System.Windows.Forms.Label();
            this.pnlY2 = new System.Windows.Forms.Panel();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlX2 = new System.Windows.Forms.Panel();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlY1 = new System.Windows.Forms.Panel();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlX1 = new System.Windows.Forms.Panel();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAtualizarWebCams = new System.Windows.Forms.Button();
            this.pbWebCam = new System.Windows.Forms.PictureBox();
            this.ofdCarregarDiferenciador = new System.Windows.Forms.OpenFileDialog();
            this.pnlInferior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlY2.SuspendLayout();
            this.pnlX2.SuspendLayout();
            this.pnlY1.SuspendLayout();
            this.pnlX1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // menuWebCam
            // 
            this.menuWebCam.Location = new System.Drawing.Point(0, 0);
            this.menuWebCam.Name = "menuWebCam";
            this.menuWebCam.Size = new System.Drawing.Size(640, 24);
            this.menuWebCam.TabIndex = 0;
            this.menuWebCam.Text = "menuStrip1";
            this.menuWebCam.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuWebCam_ItemClicked);
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.panel1);
            this.pnlInferior.Controls.Add(this.pnlY2);
            this.pnlInferior.Controls.Add(this.pnlX2);
            this.pnlInferior.Controls.Add(this.pnlY1);
            this.pnlInferior.Controls.Add(this.pnlX1);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 415);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(640, 25);
            this.pnlInferior.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDesenhado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(426, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 25);
            this.panel1.TabIndex = 4;
            // 
            // txtDesenhado
            // 
            this.txtDesenhado.AutoSize = true;
            this.txtDesenhado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesenhado.ForeColor = System.Drawing.Color.Red;
            this.txtDesenhado.Location = new System.Drawing.Point(3, 5);
            this.txtDesenhado.Name = "txtDesenhado";
            this.txtDesenhado.Size = new System.Drawing.Size(135, 15);
            this.txtDesenhado.TabIndex = 0;
            this.txtDesenhado.Text = "Nada selecionado...";
            // 
            // pnlY2
            // 
            this.pnlY2.Controls.Add(this.txtY2);
            this.pnlY2.Controls.Add(this.label3);
            this.pnlY2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlY2.Location = new System.Drawing.Point(315, 0);
            this.pnlY2.Name = "pnlY2";
            this.pnlY2.Size = new System.Drawing.Size(105, 25);
            this.pnlY2.TabIndex = 3;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(23, 3);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(67, 20);
            this.txtY2.TabIndex = 92;
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtY2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Y2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlX2
            // 
            this.pnlX2.Controls.Add(this.txtX2);
            this.pnlX2.Controls.Add(this.label2);
            this.pnlX2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlX2.Location = new System.Drawing.Point(210, 0);
            this.pnlX2.Name = "pnlX2";
            this.pnlX2.Size = new System.Drawing.Size(105, 25);
            this.pnlX2.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(26, 3);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(67, 20);
            this.txtX2.TabIndex = 92;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtX2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "X2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlY1
            // 
            this.pnlY1.Controls.Add(this.txtY1);
            this.pnlY1.Controls.Add(this.label1);
            this.pnlY1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlY1.Location = new System.Drawing.Point(105, 0);
            this.pnlY1.Name = "pnlY1";
            this.pnlY1.Size = new System.Drawing.Size(105, 25);
            this.pnlY1.TabIndex = 1;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(26, 3);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(67, 20);
            this.txtY1.TabIndex = 92;
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtY1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Y1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlX1
            // 
            this.pnlX1.Controls.Add(this.txtX1);
            this.pnlX1.Controls.Add(this.label6);
            this.pnlX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlX1.Location = new System.Drawing.Point(0, 0);
            this.pnlX1.Name = "pnlX1";
            this.pnlX1.Size = new System.Drawing.Size(105, 25);
            this.pnlX1.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(26, 2);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(67, 20);
            this.txtX1.TabIndex = 91;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtX1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 89;
            this.label6.Text = "X1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAtualizarWebCams
            // 
            this.btnAtualizarWebCams.Location = new System.Drawing.Point(582, 0);
            this.btnAtualizarWebCams.Name = "btnAtualizarWebCams";
            this.btnAtualizarWebCams.Size = new System.Drawing.Size(58, 24);
            this.btnAtualizarWebCams.TabIndex = 1;
            this.btnAtualizarWebCams.Text = "Atualizar";
            this.btnAtualizarWebCams.UseVisualStyleBackColor = true;
            this.btnAtualizarWebCams.Click += new System.EventHandler(this.BtnAtualizarWebCams_Click);
            // 
            // pbWebCam
            // 
            this.pbWebCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbWebCam.Location = new System.Drawing.Point(0, 24);
            this.pbWebCam.Name = "pbWebCam";
            this.pbWebCam.Size = new System.Drawing.Size(640, 391);
            this.pbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWebCam.TabIndex = 3;
            this.pbWebCam.TabStop = false;
            this.pbWebCam.Paint += new System.Windows.Forms.PaintEventHandler(this.PbWebCam_Paint);
            this.pbWebCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbWebCam_MouseDown);
            this.pbWebCam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbWebCam_MouseMove);
            this.pbWebCam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbWebCam_MouseUp);
            // 
            // ofdCarregarDiferenciador
            // 
            this.ofdCarregarDiferenciador.FileName = "openFileDialog1";
            // 
            // FormWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.btnAtualizarWebCams);
            this.Controls.Add(this.pbWebCam);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.menuWebCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuWebCam;
            this.Name = "FormWebCam";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWebCam_FormClosing);
            this.pnlInferior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlY2.ResumeLayout(false);
            this.pnlY2.PerformLayout();
            this.pnlX2.ResumeLayout(false);
            this.pnlX2.PerformLayout();
            this.pnlY1.ResumeLayout(false);
            this.pnlY1.PerformLayout();
            this.pnlX1.ResumeLayout(false);
            this.pnlX1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuWebCam;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlY2;
        private System.Windows.Forms.Panel pnlX2;
        private System.Windows.Forms.Panel pnlY1;
        private System.Windows.Forms.Panel pnlX1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtDesenhado;
        public System.Windows.Forms.PictureBox pbWebCam;
        private System.Windows.Forms.Button btnAtualizarWebCams;
        private System.Windows.Forms.OpenFileDialog ofdCarregarDiferenciador;
    }
}