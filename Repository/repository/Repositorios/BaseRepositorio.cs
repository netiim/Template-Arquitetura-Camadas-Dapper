using Core.Entidades;
using Core.Interfaces.Repositorios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestrutura.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : EntidadeBase
    {
        private readonly IDbConnection _connection;

        public BaseRepositorio(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<T> ObterPorIdAsync(int id)
        {
            string query = "SELECT * FROM " + typeof(T).Name + " WHERE Id = @Id";
            return await _connection.QueryFirstOrDefaultAsync<T>(query, new { Id = id });
        }

        public async Task<IEnumerable<T>> ObterTodosAsync()
        {
            string query = "SELECT * FROM " + typeof(T).Name;
            return await _connection.QueryAsync<T>(query);
        }

        public async Task AdicionarAsync(T entity)
        {
            var tableName = typeof(T).Name;
            var properties = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
            var columnNames = string.Join(", ", properties.Select(p => p.Name));
            var parameterNames = string.Join(", ", properties.Select(p => "@" + p.Name));

            var sql = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})";

            await _connection.ExecuteAsync(sql, entity);
        }

        public void AtualizarAsync(T entity)
        {
            // Implementação do método Update usando Dapper
            throw new NotImplementedException();
        }

        public void RemoverAsync(int id)
        {
            // Implementação do método Delete usando Dapper
            throw new NotImplementedException();
        }
    }
}
