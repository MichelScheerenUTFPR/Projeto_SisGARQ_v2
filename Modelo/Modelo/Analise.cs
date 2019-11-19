using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Analise
    {
        public Bgr Diferenciador { get; set; }
        public TimeSpan Intervalo { get; set; }
        public int Repetições { get; set; }

        public List<Bgr> Capturas { get; set; }
        public List<double> Sinais { get; set; }

        public void ObterDiferenciador(Image imagem, Rectangle retangulo)
        {
            Bitmap bitmap = new Bitmap(imagem);
            Image<Bgr, byte> diferenciador = new Image<Bgr, byte>(bitmap);
            Diferenciador = new Bgr();
            Diferenciador = diferenciador.GetSubRect(retangulo).GetAverage();
            bitmap.Dispose();
            diferenciador.Dispose();
        }

        public async Task IniciarAnalise(decimal tempo, decimal numCapturas, WebCam webCam, Rectangle retangulo)
        {
            Capturas = new List<Bgr>();
            Sinais = new List<double>();
            Repetições = Convert.ToInt32(tempo * numCapturas);
            Intervalo = TimeSpan.FromMilliseconds(1000 / Convert.ToInt32(numCapturas));
            for (int i = 0; i < Repetições; i++)
            {
                Capturas.Add(webCam.Matriz.ToImage<Bgr, byte>().GetSubRect(retangulo).GetAverage());
                CalcularSinal(i);
                await Task.Delay(Intervalo);
            }
        }

        private void CalcularSinal(int posicao)
        {
            Sinais.Add(Math.Sqrt(Math.Pow(Capturas[posicao].Blue - Diferenciador.Blue, 2) +
                                 Math.Pow(Capturas[posicao].Green - Diferenciador.Green, 2) +
                                 Math.Pow(Capturas[posicao].Red - Diferenciador.Red, 2)));
        }
    }
}
