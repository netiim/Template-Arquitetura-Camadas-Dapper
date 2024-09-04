using Core.Entidades;
using Core.Interfaces.Repositorios;

namespace Insfraestrutura.Repositorios
{
    public interface IProdutoRepositorio : IBaseRepositorio<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosComCategorias();
    }
}