using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
        public List<Tarefa> Read([FromServices]ITarefaRepository repository)
        {
            return repository.Read();
        }

        [HttpPost]
        public void Create([FromServices]ITarefaRepository repository, Tarefa model)
        {
            repository.Create(model);
        }

        //PUT http://localhost:5000/tarefa/0000-0000-0000-00000
        [HttpPut("{id}")]
        public void Update([FromServices]ITarefaRepository repository, string id, Tarefa model)
        {
            repository.Update(id, model);
        }

        [HttpDelete("{id}")]
        public void Delete([FromServices]ITarefaRepository repository, string id)
        {
            repository.Delete(id);
        }
    }
}