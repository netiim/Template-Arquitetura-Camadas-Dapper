using Core.Entidades;
using Dommel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestrutura.Repositorios;

public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
{
    private readonly IDbConnection _connection;

    public ProdutoRepositorio(IDbConnection connection) : base(connection)
    {
        _connection = connection;
    }
    public async Task<IEnumerable<Produto>> ObterProdutosComCategorias()
    {
        var produtos = await _connection.GetAllAsync<Produto>();

        foreach (var produto in produtos)
        {
            produto.Categoria = await _connection.GetAsync<Categoria>(produto.CategoriaID);
        }

        return produtos;
    }

}
