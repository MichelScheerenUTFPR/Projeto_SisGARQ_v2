using Modelo.Modelo.BancoDeDados;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class SqLiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionStringBuilder = new SqliteConnectionStringBuilder() { DataSource = /*"..//..//..//Persistencia//DataBase//*/"SqLiteDataBase.db" }.ToString();
            var connection = new SqliteConnection(connectionStringBuilder);
            optionsBuilder.UseSqlite(connection);
        }

        public DbSet<Resultado> Resultados { get; set; }
        public DbSet<Diferenciador> Diferenciadores { get; set; }
        public DbSet<Captura> Capturas { get; set; }
    }
}
