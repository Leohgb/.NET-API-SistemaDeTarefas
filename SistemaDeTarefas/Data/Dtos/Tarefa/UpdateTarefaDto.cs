using SistemaDeTarefas.Enums;
using SistemaDeTarefas.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTarefas.Data.Dtos.Tarefa
{
    public class UpdateTarefaDto
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }

    }
}
