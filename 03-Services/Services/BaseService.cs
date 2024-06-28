using Core.Entidades;
using Core.Interfaces.Repositorios;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : EntidadeBase
    {
        private readonly IBaseRepositorio<T> _repository;

        public BaseService(IBaseRepositorio<T> repository)
        {
            _repository = repository;
        }

        public async Task<T> ObterPorIdAsync(int id)
        {
            return await _repository.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _repository.ObterTodosAsync();
        }

        public async Task AdicionarAsync(T entity)
        {            
           await _repository.AdicionarAsync(entity);
        }

        public void AtualizarAsync(T entity)
        {
            // Implementação da lógica de negócio para atualizar usando o repositório
            _repository.AtualizarAsync(entity);
        }

        public void RemoverAsync(int Id)
        {
            // Implementação da lógica de negócio para excluir usando o repositório
            _repository.RemoverAsync(Id);
        }
    }
}
