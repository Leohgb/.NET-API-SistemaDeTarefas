using SistemaDeTarefas.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public UsuarioModel(string? nome, string? email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
