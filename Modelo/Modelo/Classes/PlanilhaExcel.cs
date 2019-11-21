using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

namespace Modelo.Modelo
{
    public class PlanilhaExcel
    {
        public ExcelPackage Excel { get; private set; }

        public PlanilhaExcel()
        {
            Excel = new ExcelPackage();
        }

        public void GerarPlanilha(Analise analise, string caminho)
        {
            caminho = caminho + " .xlsx";
            List<object[]> dados = new List<object[]>();
            for (int i = 0; i < analise.Sinais.Count; i++)
            {
                dados.Add(new object[] { analise.Capturas[i].Red, analise.Capturas[i].Green, analise.Capturas[i].Blue, analise.Sinais[i] });
            }
            var workSheet = Excel.Workbook.Worksheets.Add("Analise");
            var linhaCabecalho = new List<string[]>()
            {
                new string[] {"R", "G", "B", "Sinal"}
            };
            string tamanhoCabecalho = "A1:" + Char.ConvertFromUtf32(linhaCabecalho[0].Length + 64) + "1";
            workSheet.Cells[tamanhoCabecalho].LoadFromArrays(linhaCabecalho);
            workSheet.Cells[2, 1].LoadFromArrays(dados);

            FileInfo excelFile = new FileInfo(caminho);
            Excel.SaveAs(excelFile);
        }
    }
}
