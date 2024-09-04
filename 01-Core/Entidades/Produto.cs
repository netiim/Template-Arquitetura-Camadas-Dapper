using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Produto:EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaID { get; set; }

        // Propriedade de navegação
        public Categoria Categoria { get; set; }
    }
}
