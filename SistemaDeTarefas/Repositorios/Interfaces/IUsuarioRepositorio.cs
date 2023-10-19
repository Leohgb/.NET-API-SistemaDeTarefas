using SistemaDeTarefas.Data.Dtos.Usuario;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task Adicionar(UsuarioModel usuario);
        Task Atualizar(UsuarioModel usuario);
        Task Apagar(UsuarioModel usuario);
    }
}
