using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistencia
{
    public class Repository<T> where T : class
    {
        private SqLiteContext _context;

        public async Task Save(T obj)
        {
            using (_context = new SqLiteContext())
            {
                _context.Set<T>().Add(obj);
                await _context.SaveChangesAsync();
            }
        }

    }
}
