using Emgu.CV;
using Emgu.CV.Structure;
using System.Collections.Generic;

namespace Modelo.Modelo
{
    public static class SalvarImagens
    {
        public static void Salvar(Image<Bgr, byte> diferenciador, List<Image<Bgr,byte>> capturas, string caminho)
        {
            
            diferenciador.Save(caminho + "\\Diferenciador .bmp");
            for(int i = 0; i < capturas.Count; i++)
            {
                capturas[i].Save(caminho + "\\Captura " + (i + 1) + " .jpg");
            }
        } 
    }
}
