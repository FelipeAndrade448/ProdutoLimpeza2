using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoLimpeza2
{
    public class Fornecedor : Pessoa
    {
        public Fornecedor(Endereco endereco)
        {

        }

        public int Id { get; set; }

        [Required]
        public string NomeFantasia { get; set; }

        //public List<Produto> Produtos = new List<Produto>();

        //public int ProdutoId { get; set; }
        
    }
}
