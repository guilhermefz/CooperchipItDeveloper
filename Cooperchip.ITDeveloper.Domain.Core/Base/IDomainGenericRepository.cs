using System.Linq.Expressions;

namespace Cooperchip.ITDeveloper.Domain.Core.Base
{
    public interface IDomainGenericRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> SelecionarTodos(Expression<Func<TEntity, bool>> quando = null);
        Task<TEntity> SelecionarPorId(TKey id);
        Task Inserir(TEntity obj);
        Task Excluir(TEntity obj);
        Task ExcluirPorId(TKey id);
        Task Atualizar (TEntity obj);
        Task<int> SaveAsync();
    }
}
