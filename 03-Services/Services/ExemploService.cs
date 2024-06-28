using Core.Entidades;
using Insfraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ExemploService : BaseService<Exemplo>, IExemploService
    {
        protected readonly IExemploRepositorio _exemploRepository;

        public ExemploService(IExemploRepositorio exemploRepository)
            : base(exemploRepository)
        {
            _exemploRepository = exemploRepository;
        }
    }
}
