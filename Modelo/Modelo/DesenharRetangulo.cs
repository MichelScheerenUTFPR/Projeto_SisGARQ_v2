using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Modelo
{
    public class DesenharRetangulo
    {
        public Rectangle Retangulo { get; private set; }
        public Point PosicaoInicial { get; private set; }
        public Point PosicaoFinal { get; private set; }
        public bool MousePressionado { get; private set; }

        public DesenharRetangulo()
        {
            Retangulo = new Rectangle(0, 0, 0, 0);
            PosicaoInicial = Point.Empty;
            PosicaoFinal = Point.Empty;
            MousePressionado = false;
        }

        public void MouseDown(Point posicao)
        {
            if (!PosicaoFinal.IsEmpty)
                PosicaoFinal = Point.Empty;

            MousePressionado = true;
            PosicaoInicial = posicao;
        }

        public bool MouseMove(Point posicao)
        {
            if (MousePressionado == true)
            {
                PosicaoFinal = posicao;
                return true; 
            }
            return false;
        }

        public void MouseUp(Point posicao)
        {
            if (MousePressionado == true)
            {
                PosicaoFinal = posicao;
                MousePressionado = false;
            }
        }

        public void CriarRetangulo()
        {
            Rectangle rect = new Rectangle
            {
                X = Math.Min(PosicaoInicial.X, PosicaoFinal.X),
                Y = Math.Min(PosicaoInicial.Y, PosicaoFinal.Y),
                Width = Math.Abs(PosicaoInicial.X - PosicaoFinal.X),
                Height = Math.Abs(PosicaoInicial.Y - PosicaoFinal.Y)
            };
            Retangulo = rect;
        }

        public void CriarRetanguloManual(string X1, string X2, string Y1, string Y2)
        {
            PosicaoInicial = new Point(Convert.ToInt32(X1), Convert.ToInt32(Y1));
            PosicaoFinal = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
        }

        public bool ValidarAlturaLargura()
        {
            return Retangulo.Height != 0 && Retangulo.Width != 0;
        }

        public bool Validar()
        {
            return !PosicaoInicial.IsEmpty && !PosicaoFinal.IsEmpty;
        }

        public void Clear()
        {
            Rectangle rect = new Rectangle(0, 0, 0, 0);
            PosicaoFinal = Point.Empty;
            PosicaoInicial = Point.Empty;
            Retangulo = rect;
        }
    }
}
