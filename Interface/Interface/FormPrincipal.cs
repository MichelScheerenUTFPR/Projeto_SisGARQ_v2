using Modelo.Modelo;
using System;
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
        public FormHistoricoAnalises FormHistoricoAnalises { get; set; }
        
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
                    await Task.Run(() => Analise.IniciarAnalise(nudTempo.Value, nudCapturas.Value, FormWebCam.WebCam, FormWebCam.Retangulo.Retangulo));
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
            cpbCapturas.Visible = true;
            cpbCapturas.Enabled = true;
            AlterarCondicaoBotoes(false);
        }

        private void AlterarCondicaoBotoes(bool condicao)
        {
            btnIniciarCapturas.Enabled = condicao;
            FormArmazenamento.AtualizarBotao(condicao);
            btnObterDiferenciador.Enabled = condicao;
            btnCarregarDiferenciador.Enabled = condicao;
        }

        private void PosCondicoes()
        {
            cpbCapturas.Visible = false;
            cpbCapturas.Enabled = false;
            AlterarCondicaoBotoes(true);
        }

        private async void BtnVerHistorico_Click(object sender, EventArgs e)
        {
            if(FormHistoricoAnalises == null)
            {
                FormHistoricoAnalises = new FormHistoricoAnalises();
                await Task.Run(() => FormHistoricoAnalises.PreencherDataGrid());
                FormHistoricoAnalises.ShowDialog();

                if (FormHistoricoAnalises.Resultado != null)
                {
                    Analise.PreencherResultado(FormHistoricoAnalises.Resultado);
                    AtualizarTxtDiferenciador();
                    FormResultados.AtualizarResultados(Analise);
                    FormArmazenamento.AtualizarTextBoxBanco(FormHistoricoAnalises.Resultado.Autor, FormHistoricoAnalises.Resultado.Experimento);
                }
                FormHistoricoAnalises.Dispose();
                FormHistoricoAnalises = null;
            }
            else
            {
                FormHistoricoAnalises.ShowDialog();
            }
        }
    }
}
