using SistemaDeTarefas.Data.Dtos.Tarefa;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task Adicionar(TarefaModel tarefa);
        Task Atualizar(TarefaModel tarefa);
        Task Apagar(TarefaModel tarefa);
    }
}
