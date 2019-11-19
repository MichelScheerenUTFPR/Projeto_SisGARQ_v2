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
            int contLinha = 0;
            for (int i = 0; i < analise.Sinais.Count; i++)
            {
                contLinha = dgvResultados.Rows.Add();
                dgvResultados.Rows[contLinha].Cells[0].Value = Math.Round(analise.Capturas[i].Red, 4);
                dgvResultados.Rows[contLinha].Cells[1].Value = Math.Round(analise.Capturas[i].Green, 4);
                dgvResultados.Rows[contLinha].Cells[2].Value = Math.Round(analise.Capturas[i].Blue, 4);
                dgvResultados.Rows[contLinha].Cells[3].Value = Math.Round(analise.Sinais[i], 4);
            }
        }
    }
}
