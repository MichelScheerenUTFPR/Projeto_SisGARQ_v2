using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            dgvResultados.Columns.Add("C1", "Resultados");
            dgvResultados.Rows[dgvResultados.Rows.Add()].Cells[0].Value = "Aguardando resultados...";
            graficoResultados.Series[0].Points.AddXY(1, 0);
            graficoResultados.Series[0].Points.AddXY(1, 1);
            graficoResultados.Series[0].Points.AddXY(1, 2);
            graficoResultados.Series[0].Points.AddXY(1, 3);
            graficoResultados.Series[0].Points.AddXY(2, 2);
            graficoResultados.Series[0].Points.AddXY(3, 1);
            graficoResultados.Series[0].Points.AddXY(4, 2);
            graficoResultados.Series[0].Points.AddXY(5, 3);
            graficoResultados.Series[0].Points.AddXY(5, 2);
            graficoResultados.Series[0].Points.AddXY(5, 1);
            graficoResultados.Series[0].Points.AddXY(5, 0);
        }

        public void AtualizarResultados(Analise analise)
        {
            AtualizarGrafico(analise.Sinais);
            AtualizarDataGrid(analise);
        }

        private void AtualizarGrafico(List<double> sinais)
        {
            graficoResultados.Series[0].Points.Clear();
            for (int i = 0; i < sinais.Count; i++)
            {
                graficoResultados.Series[0].Points.AddXY(i + 1, sinais[i]);
            }
        }

        private void AtualizarDataGrid(Analise analise)
        {
            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();
            dgvResultados.Columns.Add("C1", "Captura");
            dgvResultados.Columns.Add("C2", "R");
            dgvResultados.Columns.Add("C3", "G");
            dgvResultados.Columns.Add("C4", "B");
            dgvResultados.Columns.Add("C5", "Sinais");
            int contLinha = 0;
            for (int i = 0; i < analise.Sinais.Count; i++)
            {
                contLinha = dgvResultados.Rows.Add();
                dgvResultados.Rows[contLinha].Cells[0].Value = i + 1;
                dgvResultados.Rows[contLinha].Cells[1].Value = Math.Round(analise.Capturas[i].Red, 4);
                dgvResultados.Rows[contLinha].Cells[2].Value = Math.Round(analise.Capturas[i].Green, 4);
                dgvResultados.Rows[contLinha].Cells[3].Value = Math.Round(analise.Capturas[i].Blue, 4);
                dgvResultados.Rows[contLinha].Cells[4].Value = Math.Round(analise.Sinais[i], 4);
            }
        }
    }
}
