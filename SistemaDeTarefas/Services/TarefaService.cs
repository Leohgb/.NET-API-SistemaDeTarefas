using SistemaDeTarefas.Data.Dtos.Tarefa;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios;
using SistemaDeTarefas.Repositorios.Interfaces;
using SistemaDeTarefas.Services.Interfaces;

namespace SistemaDeTarefas.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaService(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        public async Task<TarefaModel> Adicionar(CreateTarefaDto tarefaDto)
        {
            var tarefa = new TarefaModel(tarefaDto.Nome, tarefaDto.Descricao, tarefaDto.Status, tarefaDto.UsuarioId);
            await _tarefaRepositorio.Adicionar(tarefa);

            return tarefa;
        }

        public async Task<bool> Apagar(int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);

            if (tarefaPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            await _tarefaRepositorio.Apagar(tarefaPorId);
            return true;
        }

        public async Task<TarefaModel> Atualizar(UpdateTarefaDto tarefa, int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);

            if (tarefaPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }
            tarefaPorId.Nome = tarefa.Nome;
            tarefaPorId.Descricao = tarefa.Descricao;

            await _tarefaRepositorio.Atualizar(tarefaPorId);
            return tarefaPorId;
        }

        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _tarefaRepositorio.BuscarPorId(id);

        }

        public async Task<List<TarefaModel>> BuscarTodasTarefas()
        {
            return await _tarefaRepositorio.BuscarTodasTarefas();
        }
    }
}
