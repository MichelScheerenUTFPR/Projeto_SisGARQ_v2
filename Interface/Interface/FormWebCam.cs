using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormWebCam : Form
    {
        public WebCam WebCam { get; private set; }
        public DesenharRetangulo Retangulo { get; private set; }

        public FormWebCam()
        {
            InitializeComponent();
            WebCam = new WebCam();
            AtualizarListaWebCams();
        }

        private void FormWebCam_Load(object sender, EventArgs e)
        {
            Retangulo = new DesenharRetangulo();
        }

        public void AtualizarListaWebCams()
        {
            try
            {
                btnAtualizarWebCams.Enabled = false;
                WebCam.InstanciarWebCamPrincipal();
                WebCam.WebCamAtual = 0;
                menuWebCam.Items.Clear();
                menuWebCam.Items.Add("WebCam 1");
                List<int> cameras = WebCam.TestarOutrasCameras();
                for (int i = 0; i < cameras.Count && i < 6; i++)
                {
                    menuWebCam.Items.Add("WebCam " + (i + 2));
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                InicializarThreadWebCam();
                btnAtualizarWebCams.Enabled = true;
            }
        }

        public void InicializarThreadWebCam()
        {
            WebCam.WebCamThread = new Thread(ExibirImagemWebCam) { Priority = ThreadPriority.Highest };
            WebCam.WebCamThread.Start();
        }

        private void ExibirImagemWebCam()
        {
            while (true)
            {
                try
                {
                    pbWebCam.Image = WebCam.FazerCaptura(pbWebCam.Size);
                }
                catch (Exception)
                {
                }
            }
        }

        //private void WebCamIndisponivel()
        //{
        //    try
        //    {
        //        Image image = Image.FromFile(@"..\..\..\Persistencia\Imagens\WebCamNotFound.jpg");
        //        Bitmap bitmap = new Bitmap(image, pbWebCam.Size);
        //        pbWebCam.Image = bitmap;
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        private void BtnAtualizarWebCams_Click(object sender, EventArgs e)
        {
            PararThreadWebCam();
            AtualizarListaWebCams();
        }

        private async void MenuWebCam_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int indice = menuWebCam.Items.IndexOf(e.ClickedItem);
                if (indice != WebCam.WebCamAtual)
                {
                    menuWebCam.Enabled = false;
                    Thread threadAux = new Thread(ExibirImagemWebCam) { Priority = ThreadPriority.Highest };
                    await Task.Run(() => WebCam.MudarWebCam(indice, threadAux));
                    menuWebCam.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível aplicar as alterações. Verifique o estado da WebCam e tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ThreadDesligada()
        {
            return WebCam.WebCamThread.ThreadState == ThreadState.Aborted || WebCam.WebCamThread.ThreadState == ThreadState.AbortRequested;
        }

        private void FormWebCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            PararThreadWebCam();
        }

        private void PararThreadWebCam()
        {
            WebCam.WebCamThread.Abort();
            WebCam.Captura.Dispose();
        }

        public async void CarregarDiferenciador()
        {
            if(ofdCarregarDiferenciador.ShowDialog() == DialogResult.OK)
            {
                string caminho = ofdCarregarDiferenciador.FileName;
                Bitmap diferenciador = null;
                await Task.Run(() => diferenciador = new Bitmap(Image.FromFile(caminho), pbWebCam.Size));
                PararThreadWebCam();
                pbWebCam.Image = diferenciador;
            }
        }

        //Eventos necessários para o retângulo desenhado na tela
        private void PbWebCam_MouseDown(object sender, MouseEventArgs e)
        {
            Retangulo.MouseDown(e.Location);
        }
        private void PbWebCam_MouseMove(object sender, MouseEventArgs e)
        {
            if(Retangulo.MouseMove(e.Location))
                pbWebCam.Invalidate();
            
        }
        private void PbWebCam_Paint(object sender, PaintEventArgs e)
        {
            if (Retangulo.Validar())
            {
                Retangulo.CriarRetangulo();
                e.Graphics.DrawRectangle(Pens.Red, Retangulo.Retangulo);
                if (Retangulo.MousePressionado)
                {
                    txtX1.Text = Retangulo.PosicaoInicial.X.ToString();
                    txtY1.Text = Retangulo.PosicaoInicial.Y.ToString();
                    txtX2.Text = Retangulo.PosicaoFinal.X.ToString();
                    txtY2.Text = Retangulo.PosicaoFinal.Y.ToString();
                    txtDesenhado.Text = "Região selecionada!";
                    txtDesenhado.ForeColor = Color.Green;
                }
            }
        }

        private void PbWebCam_MouseUp(object sender, MouseEventArgs e)
        {
            Retangulo.MouseUp(e.Location);
            if (!Retangulo.ValidarAlturaLargura())
            {
                Retangulo.Clear();
                LimparTextBox();
                txtDesenhado.Text = "Nada selecionado...";
                txtDesenhado.ForeColor = Color.Red;
            }
        }

        public void LimparTextBox()
        {
            txtX1.Clear();
            txtX2.Clear();
            txtY1.Clear();
            txtY2.Clear();
        }

        //Retangulo Manual
        private void TxtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CriarRetanguloManual();
        }

        private void TxtY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CriarRetanguloManual();
        }

        private void TxtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CriarRetanguloManual();
        }

        private void TxtY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CriarRetanguloManual();
        }

        private void CriarRetanguloManual()
        {
            try
            {
                Retangulo.CriarRetanguloManual(txtX1.Text, txtX2.Text, txtY1.Text, txtY2.Text);
                txtDesenhado.Text = "Região selecionada!";
                txtDesenhado.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                Retangulo.Clear();
                txtDesenhado.Text = "Nada selecionado...";
                txtDesenhado.ForeColor = Color.Red;
            }
        }
    }
}
