using Microsoft.EntityFrameworkCore;

namespace EFExemplo.Data
{
    public class EFExemploContext : DbContext
    {
        public EFExemploContext(DbContextOptions<EFExemploContext> options): base(options){ }

        
    }
}
