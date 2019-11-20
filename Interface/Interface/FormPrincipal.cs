using Modelo;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormPrincipal : Form
    {
        public Analise Analise { get; set; }
        public FormWebCam FormWebCam { get; set; }
        public FormResultados FormResultados { get; set; }
        public FormArmazenamento FormArmazenamento { get; set; }

        private Thread _threadProgressBar;
        
        public FormPrincipal()
        {
            InitializeComponent();
            Analise = new Analise();
            AbrirForm(FormWebCam = new FormWebCam(), pnlWebCam);
            AbrirForm(FormResultados = new FormResultados(), pnlGrafico);
            AbrirForm(FormArmazenamento = new FormArmazenamento(Analise), pnlArmazenamento);
        }

        private void AbrirForm(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.AutoScroll = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(form);
            form.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormWebCam.Close();
            FormResultados.Close();
            FormArmazenamento.Close();
            this.Dispose();
        }

        private void BtnObterDiferenciador_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormWebCam.Retangulo.ValidarAlturaLargura())
                {
                    AlterarCondicaoBotoes(false);
                    Analise.ObterDiferenciador(FormWebCam.pbWebCam.Image, FormWebCam.Retangulo.Retangulo);
                    AtualizarTxtDiferenciador();
                    if (FormWebCam.ThreadDesligada())
                    {
                        FormWebCam.AtualizarListaWebCams();
                        btnCarregarDiferenciador.Text = "Carregar Imagem para o Diferenciador";
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma área selecionada ou WebCam indisponível!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível obter o diferenciador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AlterarCondicaoBotoes(true);
            }
            
        }

        private void AtualizarTxtDiferenciador()
        {
            txtBlue.Text = Convert.ToString(Analise.Diferenciador.Blue);
            txtGreen.Text = Convert.ToString(Analise.Diferenciador.Green);
            txtRed.Text = Convert.ToString(Analise.Diferenciador.Red);
        }

        private void BtnCarregarDiferenciador_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarCondicaoBotoes(false);
                if (!(FormWebCam.ThreadDesligada()))
                {
                    FormWebCam.CarregarDiferenciador();
                    btnCarregarDiferenciador.Text = "Remover Diferenciador";
                }
                else
                {
                    FormWebCam.AtualizarListaWebCams();
                    btnCarregarDiferenciador.Text = "Carregar Imagem para o Diferenciador";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível abrir a imagem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AlterarCondicaoBotoes(true);
            }
        }

        private async void BtnIniciarCapturas_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormWebCam.Retangulo.ValidarAlturaLargura())
                {
                    PreCondicoes();
                    InicializarThreadProgressBar();
                    await Task.Run(() => Analise.IniciarAnalise(nudTempo.Value, nudCapturas.Value, FormWebCam.WebCam, FormWebCam.Retangulo.Retangulo));
                    PararThreadProgressBar();
                    PosCondicoes();
                    FormResultados.AtualizarResultados(Analise);
                }
                else
                {
                    MessageBox.Show("Para iniciar a análise é preciso selecionar uma área de interesse na imagem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível fazer a análise!\nVerifique o estado do sistema e tente novamente\n" + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                PosCondicoes();
            }
            
        }

        private void PreCondicoes()
        {
            pgbCapturas.Visible = true;
            AlterarCondicaoBotoes(false);
        }

        private void AlterarCondicaoBotoes(bool condicao)
        {
            btnIniciarCapturas.Enabled = condicao;
            FormArmazenamento.AtualizarBotao(condicao);
            btnObterDiferenciador.Enabled = condicao;
            btnCarregarDiferenciador.Enabled = condicao;
        }

        private void InicializarThreadProgressBar()
        {
            _threadProgressBar = new Thread(AtualizarProgressBar);
            _threadProgressBar.Start();
        }

        private async void AtualizarProgressBar()
        {
            int tempoAux = 0, capturasAux = 0;
            nudTempo.Invoke(new MethodInvoker(delegate { tempoAux = Convert.ToInt32(nudTempo.Value); }));
            nudCapturas.Invoke(new MethodInvoker(delegate { capturasAux = Convert.ToInt32(nudCapturas.Value); }));

            int incremento = Convert.ToInt32(100 / (capturasAux * tempoAux));
            TimeSpan delay = TimeSpan.FromMilliseconds(1000 / Convert.ToInt32(capturasAux));
            for (decimal i = 0; i < capturasAux * tempoAux; i++)
            {
                pgbCapturas.Invoke(new MethodInvoker(delegate { pgbCapturas.Increment(incremento); }));
                await Task.Delay(delay);
            }
        }

        private void PararThreadProgressBar()
        {
            _threadProgressBar.Abort();
        }

        private void PosCondicoes()
        {
            pgbCapturas.Visible = false;
            pgbCapturas.Value = 0;
            pgbCapturas.Refresh();
            AlterarCondicaoBotoes(true);
            
        }
    }
}
