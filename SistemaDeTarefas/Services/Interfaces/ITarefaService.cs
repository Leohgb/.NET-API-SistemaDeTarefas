using SistemaDeTarefas.Data.Dtos.Tarefa;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Services.Interfaces
{
    public interface ITarefaService
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);

        Task<TarefaModel> Adicionar(CreateTarefaDto tarefa);

        Task<TarefaModel> Atualizar(UpdateTarefaDto tarefa, int id);
        Task<bool> Apagar(int id);
    }
}
