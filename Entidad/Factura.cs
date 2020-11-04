using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Entidad
{
    public class Factura
    {
        public int FacturaID {get; set;}
        public Cliente ClienteFactura {get; set;}
        public DateTime Fecha {get; set;}
        public List<DetalleFactura> DetallesFactura {get; set;}
        public decimal Total {get; set;}

        //para hacer la relacion
        public Pedido Pedido {get; set;}
        public int ClienteID {get; set;}
        
    }
}