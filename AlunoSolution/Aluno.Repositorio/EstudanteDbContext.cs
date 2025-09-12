using Aluno.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Repositorio
{
    public class EstudanteDbContext : DbContext
    {
        public EstudanteDbContext(DbContextOptions<EstudanteDbContext> options)
            : base(options)
        {
        }

        // DbSet = tabela de estudantes
        public DbSet<Estudante> Estudantes { get; set; }
    }
}
