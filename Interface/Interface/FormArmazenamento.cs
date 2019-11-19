using Modelo;
using OfficeOpenXml;
using Persistencia;
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
        public bool AnaliseSalva { get; private set; }

        public PlanilhaExcel PlanilhaExcel { get; set; }

        private readonly Analise _analise;
        
        public FormArmazenamento(Analise analise)
        {
            InitializeComponent();
            _analise = analise;
            PlanilhaExcel = new PlanilhaExcel();
        }

        private async void FormArmazenamento_Load(object sender, EventArgs e)
        {
            chbSalvarResultadosBanco.Checked = true;
            AnaliseSalva = false;
            btnArmazenamento.Enabled = false;
            await Task.Run(() => CreateDataBase.Create());
        }

        private void ChbSalvarResultadosBanco_CheckedChanged(object sender, EventArgs e)
        {
            if(chbSalvarResultadosBanco.Checked == false)
                chbSalvarResultadosBanco.Checked = true;
        }

        public void AtualizarBotao(bool ativado)
        {
            btnArmazenamento.Enabled = ativado;
        }

        public void AtualizarDefinicaoSalvamento(bool salvo)
        {
            AnaliseSalva = salvo;
        }

        private void BtnArmazenamento_Click(object sender, EventArgs e)
        {
            if(AnaliseSalva == false)
            {
                AtualizarDefinicaoSalvamento(true);
            }
            if(chbSalvarResultadosExcel.Checked == true)
            {
                if(fbdResultados.ShowDialog() == DialogResult.OK)
                {
                    string arquivo = fbdResultados.SelectedPath + "\\teste1.xlsx";
                    if (!File.Exists(arquivo))
                    {
                        PlanilhaExcel.GerarPlanilha(_analise, arquivo);
                    }
                    else if (MessageBox.Show("Um arquivo com esse nome já existe. Deseja sobrescrevê-lo?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        PlanilhaExcel.GerarPlanilha(_analise, arquivo);
                    }
                }
            }
        }
    }
}
