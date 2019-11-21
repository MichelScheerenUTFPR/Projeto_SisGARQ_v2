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
