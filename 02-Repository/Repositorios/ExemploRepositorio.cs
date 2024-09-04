using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestrutura.Repositorios
{
    public class ExemploRepositorio : BaseRepositorio<Exemplo>, IExemploRepositorio
    {
        private readonly IDbConnection _connection;

        public ExemploRepositorio(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

    }
}
