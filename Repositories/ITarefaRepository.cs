using System.Collections.Generic;
using TodoBackEnd.Models;

namespace TodoBackEnd.Repositories
{
    public interface ITarefaRepository
    {
        List<Tarefa> Read();
        void Create(Tarefa model);
        void Update(string id, Tarefa model);
        void Delete(string id);
    }
}