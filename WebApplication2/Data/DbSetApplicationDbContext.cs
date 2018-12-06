using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public partial class ApplicationDbContext
    {
        public DbSet<WebApplication2.Models.Administrador> Administrador { get; set; }

        public DbSet<WebApplication2.Models.Aluno> Aluno { get; set; }

        public DbSet<WebApplication2.Models.Professor> Professor { get; set; }
    }
}
