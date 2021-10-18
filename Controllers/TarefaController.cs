using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoBackEnd.Models;
using TodoBackEnd.Repositories;

namespace TodoBackEnd.Controllers
{
    [ApiController]
    [Route("tarefa")]
    public class TarefaController: ControllerBase
    {        
        // GET http://localhost:5000/tarefa
        [HttpGet]
        public List<Tarefa> Read([FromServices]TarefaContext context)
        {
            return context.Tarefas.ToList();
        }

        [HttpPost]
        public void Create([FromServices]TarefaContext context, Tarefa model)
        {
            context.Add(model);
            context.SaveChanges();
        }

        //PUT http://localhost:5000/tarefa/0000-0000-0000-00000
        [HttpPut("{id}")]
        public void Update([FromServices]TarefaContext context, string id, Tarefa model)
        {
            var tarefa = context.Tarefas.SingleOrDefault(t => t.Id == id);
            tarefa.Texto = model.Texto;
            tarefa.Finalizada = model.Finalizada;
            context.SaveChanges();

            // model.Id = id;
            // context.Entry(model).State = EntityState.Modified;
            // context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete([FromServices]TarefaContext context, string id)
        {
            var parameters = new object[] {id};
            context.Database.ExecuteSqlRaw("DELETE FROM Tarefas WHERE Id = @id", parameters);
        }
    }
}