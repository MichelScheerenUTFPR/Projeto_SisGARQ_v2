using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class CreateDataBase
    {
        private static SqLiteContext _context;

        public static void Create()
        {
            using (_context = new SqLiteContext())
            {
                _context.Database.EnsureCreated();
            }
        }
    }
}
