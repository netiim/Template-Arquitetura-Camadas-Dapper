using System.Linq.Expressions;

namespace Core.Interfaces.Services;

public interface IBaseService<T> where T : class
{
    Task<IEnumerable<T>> ObterTodosAsync();
    Task<T> ObterPorIdAsync(int id);
    Task AdicionarAsync(T entity);
    void AtualizarAsync(T entity);
    void RemoverAsync(int id);
    //Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
}
