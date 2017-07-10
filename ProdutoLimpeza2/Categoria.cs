using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoLimpeza2
{
    public class Categoria
    {
        public Categoria(TipoDeCategoria tipoDeCategoria)
        {

        }

        public int Id { get; set; }

        public TipoDeCategoria TipoDeCategoria { get; set; }

        public List<Produto> ListaDeProdutos { get; set; }
    }
}
