using Core.Entidades;
using System.Linq.Expressions;

namespace Core.Interfaces.Repositorios;

public interface IBaseRepositorio<T> where T : EntidadeBase
{
    Task<IEnumerable<T>> ObterTodosAsync();
    Task<T> ObterPorIdAsync(int id);
    Task AdicionarAsync(T entity);
    void AtualizarAsync(T entity);
    void RemoverAsync(int id);
   // IEnumerable<T> FindAsync(Expression<Func<T, bool>> predicate);
}
