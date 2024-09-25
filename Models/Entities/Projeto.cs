using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using gerenciamentoapirest.Models.Entities;

namespace gerenciamentoapirest.Models.Entities
{

    [Table("Projeto")]
    public class Projeto : BaseEntity
    {
        internal int id;

        [Required]
            public string Nome { get; set; } // Nome do Projeto

            [Required]
            public string Descricao { get; set; } // Descrição do projeto

            [Required]
            public DateTime DataInicio { get; set; } // Data de inicio do projeto

            public DateTime? DataFim { get; set; } // Data final do projeto

            // Relacionamento com a classe Tarefa
            public ICollection<Tarefa> Tarefas { get; set; }

    }
}


