using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoLimpeza2
{
    public class Venda
    {
        public int Id { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public DateTime DataVenda { get; set; }

        public double ValorTotal { get; set; }

        private StatusVenda statusVenda = StatusVenda.Aberto;
        public StatusVenda StatusVenda
        {
            get
            {
                return statusVenda;
            }
            set
            {
                statusVenda = value;
            }
        }

        [Required]
        public IList<Pedido> Pedido { get; set; }

#region Metodos
        
        public void ValorTotalVenda(IList<Pedido> pedidos)
        {
            foreach (var pedido in pedidos)
            {
                ValorTotal += pedido.ValorTotal;
                pedido.StatusDoPedido = StatusPedido.Faturar;

                // Retira do estoque a quantidade de produtos realizados na venda
                foreach (var produto in pedido.Produtos)
                {
                    produto.QuantidadeProduto -= pedido.QuantidadeProduto;
                }
            } 
        }

        public void CancelaVenda(Venda venda)
        {
            if (venda.StatusVenda != StatusVenda.Cancelado && venda.StatusVenda != StatusVenda.Faturado)
            {
                statusVenda = StatusVenda.Cancelado;
            }
        }

        public void FaturaVenda(Venda venda)
        {
            venda.StatusVenda = StatusVenda.Faturado;
        }

        public void PreencheVenda()
        {
            Codigo = "VE0001";
            DataVenda = Convert.ToDateTime(2017-07-07);
        }

 #endregion
    }
}
