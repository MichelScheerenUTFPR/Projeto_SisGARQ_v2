using System;
using System.Collections.Generic;

namespace Modelo.Modelo.BancoDeDados
{
    public class Resultado
    {
        public int ID { get; set; }

        public string Autor { get; set; }

        public string Experimento { get; set; }

        public DateTime Data { get; set; }

        public virtual Diferenciador Diferenciador { get; set; }

        public virtual List<Captura> Capturas { get; set; }

        public Resultado()
        {
            Data = DateTime.Now;
        }


    }
}
