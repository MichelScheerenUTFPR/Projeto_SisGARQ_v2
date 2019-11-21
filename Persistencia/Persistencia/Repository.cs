using Modelo.Modelo.BancoDeDados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

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

        public async Task<List<Resultado>> GetAll()
        {
            using (_context = new SqLiteContext())
            {
                return await _context.Resultados.OrderByDescending(x => x.Data).ToListAsync();
            }
        }

        public async Task<Resultado> Find(Expression<Func<Resultado, bool>> predicado)
        {
            using (_context = new SqLiteContext())
            {
                return await _context.Resultados.Where(predicado).Include("Diferenciador").Include("Capturas").FirstOrDefaultAsync();
            }
        }

        public async Task Delete(int resultadoID)
        {
            using (_context = new SqLiteContext())
            {
                Resultado resultado = await _context.Resultados.Where(x => x.ID == resultadoID).FirstOrDefaultAsync();
                _context.Resultados.Remove(resultado);
                await _context.SaveChangesAsync();
            }
        }

    }
}
