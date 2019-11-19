using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public class SqLiteService
    {
        private CreateDataBase _createDataBase;

        public SqLiteService()
        {
            _createDataBase = new CreateDataBase();
        }

        public void Criar()
        {
            _createDataBase.Create();
        }
    }
}
