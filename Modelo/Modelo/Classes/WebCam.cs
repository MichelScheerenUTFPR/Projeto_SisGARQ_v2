using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Drawing;
using System.IO;
using Emgu.CV;
using System.Threading.Tasks;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Modelo.Modelo
{
    public class WebCam
    {
        public VideoCapture Captura { get; set; }

        public Mat Matriz { get; private set; }

        public Thread WebCamThread { get; set; }

        public int WebCamAtual { get; set; }


        public void InstanciarWebCamPrincipal()
        {
            Captura = new VideoCapture(0);
        }

        public void TentarConexao(int indice)
        {
            Captura.Dispose();
            Captura = new VideoCapture(indice);
        }

        public Bitmap FazerCaptura(Size size)
        {
            Matriz = Captura.QueryFrame();
            CvInvoke.Resize(Matriz, Matriz, size);
            return Matriz.Bitmap;
        }

        public static List<int> TestarOutrasCameras()
        {
            int camera = 1;
            List<int> cameras = new List<int>();
            while (camera != -1)
            {
                VideoCapture aux = new VideoCapture(camera);
                if (aux.IsOpened)
                {
                    cameras.Add(camera);
                    camera++;
                }
                else
                {
                    camera = -1;
                }
                aux.Dispose();
            }
            return cameras;
        }

        public async Task MudarWebCam(int indice, Thread thread)
        {
            VideoCapture captureAux = new VideoCapture(indice);
            await Task.Run(() => WebCamThread.Abort());
            await Task.Run(() => Captura.Dispose());
            Captura = captureAux;
            WebCamThread = thread;
            thread.Start();
            WebCamAtual = indice;
        }
    }
}
