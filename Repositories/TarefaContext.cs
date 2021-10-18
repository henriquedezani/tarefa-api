using Microsoft.EntityFrameworkCore;
using TodoBackEnd.Models;

namespace TodoBackEnd.Repositories
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options): base(options) {}
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}