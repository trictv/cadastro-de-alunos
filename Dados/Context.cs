using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using p2.Models;

namespace p2.Dados
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Aluno> Alunos { set; get; }
        public DbSet<Disciplina> Disciplinas { set; get; }
        public DbSet<Nota> Notas { set; get; }
        public DbSet<Usuario> Usuarios { set; get; }
    }
}
