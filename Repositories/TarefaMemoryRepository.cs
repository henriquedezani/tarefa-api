using System.Collections.Generic;
using TodoBackEnd.Models;
using System.Linq;

namespace TodoBackEnd.Repositories
{
    public class TarefaMemoryRepository : ITarefaRepository
    {
        public List<Tarefa> tarefas = new List<Tarefa>();

        public List<Tarefa> Read()
        {
            if(tarefas.Count == 0) {
                tarefas.Add(new Tarefa{Id = "1", Texto = "Estudar para a prova", Finalizada = true});
                tarefas.Add(new Tarefa{Id = "2", Texto = "Lavar o carro", Finalizada = false});
            }
            return tarefas;
        }

        public void Create(Tarefa model)
        {
            tarefas.Add(model);
        }

        public void Update(string id, Tarefa model)
        {
            // SELECT top(1) * FROM Tarefa WHERE Id = @id
            var tarefa = this.tarefas.SingleOrDefault(t => t.Id == id);
            tarefa.Finalizada = model.Finalizada;
        }

        public void Delete(string id)
        {
            var tarefa = this.tarefas.SingleOrDefault(t => t.Id == id);
            tarefas.Remove(tarefa);
        }
    }
}