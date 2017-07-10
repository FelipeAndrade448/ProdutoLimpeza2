using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoLimpeza2
{
    public class Cliente : Pessoa
    {
        public Cliente(Endereco endereco)
        {

        }
        
        public int Id { get; set; }

        [Required]
        public string Filiacao { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public double LimiteCredito { get; set; }

        private TipoStatus tipoStatus = TipoStatus.Bom;
        public TipoStatus TipoStatus
        {
            get
            {
                return tipoStatus;
            }
            set
            {
                tipoStatus = value;
            }
        }

        public IList<Pedido> Pedidos { get; set; }

        public int PedidoId { get; set; }

        public IList<Venda> Vendas { get; set; }

    }
}
