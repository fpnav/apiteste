using System.Collections.Generic;
using Dominio.Entidades;

namespace Dominio.Entidades
{
    public class PedidoVm
    {
        public Cliente Cliente { get; set; }
        public List<Product> Produtos { get; set; }
    }
}