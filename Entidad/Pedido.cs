using System;
using System.Collections.Generic;
namespace Entidad
{
    public class Pedido
    {
        public int PedidoID {get;set;}
        public DateTime Fecha {get;set;}
        public Factura Factura {get;set;}
        public string Direccion {get;set;}
        public List<Estado> Estados {get;set;}


        public int PersonaID {get;set;}
        public Persona Persona {get;set;}
    }
}