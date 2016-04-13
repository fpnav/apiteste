using System;
using Dominio.Servicos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes.Servicos
{
    [TestClass]
    public class TesteServicoOrdemDePedidos
    {
        [TestMethod]
        public void TesteSeRecuperaPedidosPorCliente()
        {
            var clienteId = "1";
            var servico = new ServicoOrdemDePedido();
            var teste = servico.RetornaListaDePedidosPorCliente(clienteId);
            Assert.AreNotEqual(null, teste);
        }
    }
}
