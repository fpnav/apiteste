using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio.Servicos;

namespace ApiTeste2.Controllers
{
    public class OrdemPedidoController : ApiController
    {
        public ServicoOrdemDePedido Servico { get; private set; }

        public OrdemPedidoController()
        {
            Servico = new ServicoOrdemDePedido();
        }

        public IHttpActionResult GetPedidos(string id)
        {
            var pedidosPorCliente = Servico.RetornaListaDePedidosPorCliente(id);
            return Ok(pedidosPorCliente);
        }

    }
}
