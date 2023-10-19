using SistemaDeTarefas.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }
        //É uma referência ao tipo de dados que a propriedade "Usuario" pode armazenar
        public virtual UsuarioModel? Usuario { get; set; }

        public TarefaModel(string? nome, string? descricao, StatusTarefa status, int? usuarioId)
        {
            Nome = nome;
            Descricao = descricao;
            Status = status;
            UsuarioId = usuarioId;
        }
    }
}
