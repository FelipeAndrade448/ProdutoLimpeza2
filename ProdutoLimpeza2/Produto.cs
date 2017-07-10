using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoLimpeza2
{
    public class Produto
    {
        public Produto(TipoDeCategoria tipoDeCategoria, Fornecedor fornecedor)
        {

        }
        public int Id { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataFabricacao { get; set; }

        [Required]
        public DateTime DataVencimento { get; set; }

        [Required]
        public double Preco { get; set; }

        [Required]
        public int QuantidadeProduto { get; set; }

        public TipoDeCategoria TipoDeCategoria { get; set; }

        public Fornecedor Fornecedor { get; set; }
        //public List<Fornecedor> ListaFornecedores { get; set; }

        //public int FornecedorId { get; set; }
    }
}
