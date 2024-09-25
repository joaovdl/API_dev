using gerenciamentoapirest.Models.Entities;
using System.ComponentModel.DataAnnotations;



namespace gerenciamentoapirest.Models
{
    public class Tarefa: BaseEntity
    {
            [Required]
            public new int Id { get; set; }  // Identificador único da tarefa

            [Required]
            public string Titulo { get; set; }  // Título da tarefa

            [Required]
            public string Descricao { get; set; }  // Descrição da tarefa

            [Required]
            public string Prioridade { get; set; }  // Prioridade: 'alta', 'média', 'baixa'

            [Required]
            public int UsuarioAtribuido { get; set; }  // Id do usuário atribuído à tarefa 

            [Required]
            public StatusProjeto Status { get; set; }  // Status da tarefa: 'não iniciada', 'incompleta', 'completed'

            [Required]
            public DateTime DataVencimento { get; set; }  // Data de vencimento da tarefa 

            [Required]
            public DateTime CriadoEm { get; set; }  // Data de criação da tarefa

            [Required]
            public DateTime AtualizadoEm { get; set; }  // Data de última atualização da tarefa

            [Required]
            public int ProjetoID { get; set; }  //Projeto a qual a tarefa está relacionada

            public Projeto Projeto { get; set; }
    }

    public enum StatusProjeto
    {
        NãoIniciada,
        EmAandamento,
        Finalizada
    }

    public enum PrioridadeTarefa
    {
        Baixa,
        Média,
        Alta
    }
}
