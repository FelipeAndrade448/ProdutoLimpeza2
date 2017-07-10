using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProdutoLimpeza2;
using System.Collections.Generic;

namespace UnitTestProdutoLimpeza
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public bool VerificarDadosPedido()
        {
            Endereco Endereco = new Endereco()
            {
                Id = 8,
                Rua = "A",
                Numero = 6,
                Cidade = "Ibirite",
                Cep = "32400-000",
                Uf = "MG"
            };

            Endereco EnderecoFornecedor = new Endereco()
            {
                Id =53,
                Rua = "Alameda",
                Numero = 65,
                Cidade = "Ibirite",
                Cep = "32400-000",
                Uf = "MG",
                Sala = "530D"
            };


            Cliente Cliente = new Cliente(Endereco)
            {
                Id = 32,
                Nome = "João",
                Codigo = "C7758",
                Telefone = 319992240,
                Filiacao = "mae e pai",
                Cpf = "02365896587",
                Endereco = Endereco

            };

            Fornecedor Fornecedor = new Fornecedor(EnderecoFornecedor)
            {
                Id = 2,
                Nome = "Triangulo Distribuidora",
                NomeFantasia = "YPE",
                Codigo = "FO23658",
                Telefone = 312569852,
                Endereco = EnderecoFornecedor
            };

            TipoDeCategoria TipoDeCategoria = new TipoDeCategoria()
            {
                Id = 25,
                Nome = "Detergente",
                Codigo = 2554
            };

            Produto Produto = new Produto(TipoDeCategoria, Fornecedor)
            {
                Id = 28,
                Codigo = "PRO23658",
                Nome = "Detergente YPE",
                DataFabricacao = new DateTime(2017, 02, 01),
                DataVencimento = new DateTime(2017, 12, 31),
                Preco = 1.25,
                QuantidadeProduto = 200,
                TipoDeCategoria = TipoDeCategoria,
                Fornecedor = Fornecedor
            };
            //Fornecedor.Produtos.Add(Produto);
            //Produto.ListaFornecedores.Add(Fornecedor);

            Categoria categoria = new Categoria(TipoDeCategoria)
            {
                Id = 28,
                TipoDeCategoria = TipoDeCategoria                
            };
            categoria.ListaDeProdutos = new List<Produto>();
            categoria.ListaDeProdutos.Add(Produto);            

            Pedido pedido = new Pedido(Cliente)
            {
                Id = 95,
                Codigo = "P63285",
                DataElaboracao = new DateTime(2017 - 07 - 07),
                QuantidadeProduto = 8,
                Cliente = Cliente
            };
            pedido.Produtos = new List<Produto>();
            pedido.Produtos.Add(Produto);

            return true;
        }
    }
}
