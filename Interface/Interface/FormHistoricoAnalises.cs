using Modelo.Modelo.BancoDeDados;
using Persistencia.Persistencia;
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
    public partial class FormHistoricoAnalises : Form
    {
        private readonly Repository _repository;
        public Resultado Resultado { get; set; }
        public FormHistoricoAnalises()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public async Task PreencherDataGrid()
        {
            dgvResultados.Rows.Clear();
            List<Resultado> resultados = await _repository.GetAll();
            int contLinha;
            for (int i = 0; i < resultados.Count; i++)
            {
                contLinha = dgvResultados.Rows.Add();
                dgvResultados.Rows[contLinha].Cells[0].Value = resultados[i].ID;
                dgvResultados.Rows[contLinha].Cells[1].Value = resultados[i].Data;
                dgvResultados.Rows[contLinha].Cells[2].Value = resultados[i].Autor;
                dgvResultados.Rows[contLinha].Cells[3].Value = resultados[i].Experimento;
            }
        }

        private async void BtnCarregarAnálise_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvResultados.CurrentRow.Cells[0].Value.ToString());
                Resultado = await _repository.Find(x => x.ID == id);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível recuperar a Análise!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnApagarAnalise_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvResultados.CurrentRow.Cells[0].Value.ToString());
                if(MessageBox.Show("Tem certeza que deseja apagar a análise?\nDados apagados NÃO PODEM ser recuperados!", "AVISO", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    await _repository.Delete(id);
                    MessageBox.Show("Análise apagada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                    await PreencherDataGrid();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível apagar a Análise!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
