using EmguCV.Modelo;
using EmguCV.Modelo.BancoDeDados;
using Modelo;
using OfficeOpenXml;
using Persistencia;
using Persistencia.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormArmazenamento : Form
    {
        private readonly Analise _analise;
        private Repository _repository;
        private Resultado _resultado;
        private Diferenciador _diferenciador;
        private List<Captura> _capturas;
        
        public FormArmazenamento(Analise analise)
        {
            InitializeComponent();
            _analise = analise;
            _capturas = new List<Captura>();
        }

        private async void FormArmazenamento_Load(object sender, EventArgs e)
        {
            btnSalvarBanco.Enabled = false;
            btnSalvarExtras.Enabled = false;
            await Task.Run(() => CreateDataBase.Create());
        }

        public void AtualizarBotao(bool condicao)
        {
            if (condicao == true && _analise.Capturas == null)
                return;

            btnSalvarBanco.Enabled = condicao;
            btnSalvarExtras.Enabled = condicao;
        }

        private async void BtnSalvarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                if (StringInvalida(txtAutor.Text) || StringInvalida(txtDescricao.Text))
                    throw new Exception("Um ou mais campos não foram preenchidos!");

                _repository = new Repository();
                CriarInstancias();
                int fk_Resultado;

                await _repository.Save(_resultado);
                fk_Resultado = await _repository.Last();

                _diferenciador.ResultadoID = fk_Resultado;
                _capturas.ForEach(x => x.ResultadoID = fk_Resultado);

                await _repository.Save(_diferenciador);
                await _repository.Save(_capturas);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CriarInstancias()
        {
            _resultado = new Resultado()
            {
                Autor = txtAutor.Text,
                Experimento = txtDescricao.Text
            };
            _diferenciador = new Diferenciador()
            {
                Blue = _analise.Diferenciador.Blue,
                Green = _analise.Diferenciador.Green,
                Red = _analise.Diferenciador.Red
            };
            for (int i = 0; i < _analise.Capturas.Count; i++)
            {
                _capturas.Add(new Captura()
                {
                    Blue = _analise.Capturas[i].Blue,
                    Green = _analise.Capturas[i].Green,
                    Red = _analise.Capturas[i].Red,
                    Sinal = _analise.Sinais[i]                    
                });
            }
        }

        private async void BtnSalvarExtras_Click(object sender, EventArgs e)
        {
            try
            {
                if (StringInvalida(txtNomeArquivo.Text))
                    throw new Exception("Nome do arquivo inválido!");
                if (fbdResultados.ShowDialog() == DialogResult.OK)
                {
                    string caminho = fbdResultados.SelectedPath + "\\" + txtNomeArquivo.Text;
                    if (chbSalvarResultadosExcel.Checked == true)
                    {
                        await SalvarExcel(caminho);
                    }
                    if(chbSalvarImagensPC.Checked == true)
                    {
                        await SalvarImagensComputador(caminho);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static bool StringInvalida(string texto)
        {
            return String.IsNullOrEmpty(texto) || String.IsNullOrWhiteSpace(texto);
        }

        private async Task SalvarExcel(string caminho)
        {
            bool salvo = false;
            PlanilhaExcel planilhaExcel = new PlanilhaExcel();
            if (!File.Exists(caminho))
            {
                await Task.Run(() => planilhaExcel.GerarPlanilha(_analise, caminho));
                salvo = true;
            }
            else if (MessageBox.Show("Um arquivo com esse nome já existe. Deseja sobrescrevê-lo?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                await Task.Run(() => planilhaExcel.GerarPlanilha(_analise, caminho));
                salvo = true;
            }
            if (salvo)
                MessageBox.Show("Arquivo Salvo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private async Task SalvarImagensComputador(string caminho)
        {
            bool salvo = false;
            if (Directory.Exists(caminho))
            {
                int num = 1;
                while (Directory.Exists(caminho + num))
                {
                    num++;
                }
                caminho += "" + num;
                Directory.CreateDirectory(caminho);
                await Task.Run(() => SalvarImagens.Salvar(_analise.ImagemDiferenciador, _analise.ImagensCapturas, caminho));
                salvo = true;
            }
            else
            {
                Directory.CreateDirectory(caminho);
                await Task.Run(() => SalvarImagens.Salvar(_analise.ImagemDiferenciador, _analise.ImagensCapturas, caminho));
                salvo = true;
            }
            if(salvo)
                MessageBox.Show("Imagens Salvas!", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
