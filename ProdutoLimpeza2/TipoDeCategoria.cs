using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoLimpeza2
{
    public class TipoDeCategoria
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Codigo { get; set; }

        //[Required]
        //public List<Produto> Produtos { get; set; }

        //public int ProdutoId { get; set; }
    }
}
