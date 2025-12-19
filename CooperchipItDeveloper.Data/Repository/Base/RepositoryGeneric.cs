using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ItDeveloper.Domain.Entities.Base;
using Cooperchip.ITDeveloper.Domain.Core.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Cooperchip.ITDeveloper.Repository.Base
{
    public abstract class RepositoryGeneric<TEntity, Tkey> : IDomainGenericRepository<TEntity, Tkey> where TEntity : EntityBase, new()
    {
        protected ITDeveloperDbContext _context;

        protected RepositoryGeneric(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public virtual async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public virtual async Task Atualizar(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await SaveAsync();
        }

        public void Dispose()
        {
            _context?.DisposeAsync();
        }

        public virtual async Task Excluir(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Deleted;
            await SaveAsync();
        }

        public virtual async Task ExcluirPorId(Tkey id)
        {
            TEntity obj = await SelecionarPorId(id);
            await Excluir(obj);
        }

        public virtual async Task Inserir(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            await SaveAsync();
        }

        public async Task<TEntity> SelecionarPorId(Tkey id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> SelecionarTodos(Expression<Func<TEntity, bool>> quando = null)
        {
            if (quando == null)
                return await _context.Set<TEntity>().AsNoTracking().ToListAsync();

            return await _context.Set<TEntity>().AsNoTracking().Where(quando).ToListAsync();
        }
    }
}
