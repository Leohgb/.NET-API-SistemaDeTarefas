using SistemaDeTarefas.Data.Dtos.Usuario;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(CreateUsuarioDto usuarioDto);
        Task<UsuarioModel> Atualizar(UpdateUsuarioDto usuario, int id);
        Task<bool> Apagar(int id);
    }
}
