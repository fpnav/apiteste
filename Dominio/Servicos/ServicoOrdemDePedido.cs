using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Servicos
{
    /// <summary>
    /// Serviço responsável por dados sobre Ordens de Pedido
    /// </summary>
    public class ServicoOrdemDePedido
    {

        public List<PedidoVm> RetornaListaDePedidosPorCliente(string idCliente)
        {
            //Criando Pedidos fake
            var endereco1 = new Endereco { Bairro = "Bairro1", Cep = "17500-000", Numero = "123", Rua = "Rua teste" };
            var cliente1 = new Cliente { Endereco = endereco1, Email = "email1@teste.com", Nome = "Asdrubal", Id = 1 };

            var listDeproducts = new List<Product>
            { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
            };

            var pedido1 = new PedidoVm { Cliente = cliente1, Produtos = listDeproducts };

            var listaDePedidos = new List<PedidoVm>();
            listaDePedidos.Add(pedido1);

            return listaDePedidos;
        }

    }
}
