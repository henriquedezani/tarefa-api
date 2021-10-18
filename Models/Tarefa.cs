using System.ComponentModel.DataAnnotations;

namespace TodoBackEnd.Models
{
    public class Tarefa
    {
        public string Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Texto { get; set; }
        public bool Finalizada { get; set; }
    }
}