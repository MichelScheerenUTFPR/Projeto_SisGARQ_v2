using Emgu.CV;
using Emgu.CV.Structure;
using Modelo.Modelo.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Analise
    {
        public Bgr Diferenciador { get; set; }
        public Image<Bgr, byte> ImagemDiferenciador { get; set; }
        public TimeSpan Intervalo { get; set; }
        public int Repetições { get; set; }
        public List<Bgr> Capturas { get; set; }
        public List<Image<Bgr, byte>> ImagensCapturas { get; set; }
        public List<double> Sinais { get; set; }

        public void ObterDiferenciador(Image imagem, Rectangle retangulo)
        {
            Bitmap bitmap = new Bitmap(imagem);
            ImagemDiferenciador = new Image<Bgr, byte>(bitmap).GetSubRect(retangulo);
            Diferenciador = ImagemDiferenciador.GetAverage();
            bitmap.Dispose();
        }

        public async Task IniciarAnalise(decimal tempo, decimal numCapturas, WebCam webCam, Rectangle retangulo)
        {
            Capturas = new List<Bgr>();
            Sinais = new List<double>();
            ImagensCapturas = new List<Image<Bgr, byte>>();
            Repetições = Convert.ToInt32(tempo * numCapturas);
            Intervalo = TimeSpan.FromMilliseconds(1000 / Convert.ToInt32(numCapturas));
            for (int i = 0; i < Repetições; i++)
            {
                lock (webCam)
                {
                    ImagensCapturas.Add(webCam.Matriz.ToImage<Bgr, byte>().GetSubRect(retangulo));
                }
                
                Capturas.Add(ImagensCapturas[i].GetAverage());
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

        public void PreencherResultado(Resultado resultado)
        {
            Diferenciador = new Bgr()
            {
                Blue = resultado.Diferenciador.Blue,
                Green = resultado.Diferenciador.Green,
                Red = resultado.Diferenciador.Red
            };
            Capturas = new List<Bgr>();
            Sinais = new List<double>();
            for (int i = 0; i < resultado.Capturas.Count; i++)
            {
                Capturas.Add(new Bgr()
                {
                    Blue = resultado.Capturas[i].Blue,
                    Green = resultado.Capturas[i].Green,
                    Red = resultado.Capturas[i].Red
                });
                Sinais.Add(resultado.Capturas[i].Sinal);
            }
            if(ImagemDiferenciador != null)
            {
                ImagemDiferenciador.Dispose();
                ImagemDiferenciador = null;
            }
            if(ImagensCapturas != null)
            {
                foreach (var item in ImagensCapturas)
                {
                    item.Dispose();
                }
                ImagensCapturas = null;
            }
        }
    }
}
