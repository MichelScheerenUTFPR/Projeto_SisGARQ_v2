using EmguCV.Modelo.BancoDeDados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistencia
{
    public class Repository
    {
        private SqLiteContext _context;

        public async Task Save(Resultado obj)
        {
            using (_context = new SqLiteContext())
            {
                _context.Resultados.Add(obj);
               await _context.SaveChangesAsync();
            }
        }

        public async Task Save(Diferenciador obj)
        {
            using (_context = new SqLiteContext())
            {
                _context.Diferenciadores.Add(obj);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Save(IEnumerable<Captura> obj)
        {
            using (_context = new SqLiteContext())
            {
                foreach (var item in obj)
                {
                    _context.Capturas.Add(item);
                }
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> Last()
        {
            using (_context = new SqLiteContext())
            {
                Resultado resultado = await _context.Resultados.LastAsync();
                return resultado.ID;
            }
        }

        public async Task<IEnumerable<Resultado>> GetAll()
        {
            using (_context = new SqLiteContext())
            {
                return await _context.Resultados.ToListAsync();
            }
        }
    }
}
