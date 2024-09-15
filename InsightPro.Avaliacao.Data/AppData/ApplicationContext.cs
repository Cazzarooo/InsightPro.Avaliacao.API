using InsightPro.Avaliacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsightPro.Avaliacao.Data.AppData
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<AvaliacaoEntity> Avaliacao { get; set; }
    }
}
