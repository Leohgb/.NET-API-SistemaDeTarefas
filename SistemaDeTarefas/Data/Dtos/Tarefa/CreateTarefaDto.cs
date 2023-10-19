using SistemaDeTarefas.Enums;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Dtos.Tarefa
{
    public class CreateTarefaDto
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }
    }
}
