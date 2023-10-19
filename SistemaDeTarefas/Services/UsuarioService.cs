using SistemaDeTarefas.Data.Dtos.Usuario;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;
using SistemaDeTarefas.Services.Interfaces;

namespace SistemaDeTarefas.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public async Task<UsuarioModel> Adicionar(CreateUsuarioDto usuarioDto)
        {
            var usuario = new UsuarioModel(usuarioDto.Nome, usuarioDto.Email);
            await _usuarioRepositorio.Adicionar(usuario);

            return usuario;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            await _usuarioRepositorio.Apagar(usuarioPorId);
            return true;
        }

        public async Task<UsuarioModel> Atualizar(UpdateUsuarioDto usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }
            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            await _usuarioRepositorio.Atualizar(usuarioPorId);
            return usuarioPorId;
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
           return await _usuarioRepositorio.BuscarPorId(id);

        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
           return await _usuarioRepositorio.BuscarTodosUsuarios();
        }
    }
}
