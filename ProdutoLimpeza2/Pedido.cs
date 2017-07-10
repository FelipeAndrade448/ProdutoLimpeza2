using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoLimpeza2
{
    public class Pedido
    {
        public Pedido (Cliente cliente) 
        {

        }

        public int Id { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public DateTime DataElaboracao { get; set; }

        [Required]
        public int QuantidadeProduto { get; set; }

        public double ValorTotal { get; set; }

        private StatusPedido statusDoPedido = StatusPedido.Aberto;
        public StatusPedido StatusDoPedido
        {
            get
            {
                return statusDoPedido;
            }
            set
            {
                statusDoPedido = value;
            }
        }

        [Required]
        public List<Produto> Produtos { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        #region Metodos

        public void CalculaPedido(IList<Produto> produto)
        {
            if(StatusDoPedido == StatusPedido.Aberto)
            {
                foreach (var produtos in produto)
                {
                    ValorTotal += (produtos.Preco * QuantidadeProduto);
                    StatusDoPedido = StatusPedido.Faturar;
                }
            }            
        }

        public void CancelaPedido(Pedido pedido)
        {
            if (pedido.StatusDoPedido == StatusPedido.Aberto || pedido.StatusDoPedido == StatusPedido.Faturar)
            {
                StatusDoPedido = StatusPedido.Cancelado;
            }
        }

        #endregion
    }
}
