using System;
using ApiTeste2.Controllers;
using Dominio.Servicos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes.Api
{
    [TestClass]
    public class TesteApiServicoOrdemDePedidos
    {
        [TestMethod]
        public void TesteApiSeRecuperaPedidosPorCliente()
        {
            var clienteId = "1";
            var controller = new OrdemPedidoController();
            var teste = controller.GetPedidos(clienteId);
            Assert.AreNotEqual(null, teste);
        }
    }
}
