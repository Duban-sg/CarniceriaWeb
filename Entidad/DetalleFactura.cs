using System.ComponentModel.DataAnnotations;
namespace Entidad
{
    public class DetalleFactura
    {
        public int DetalleFacturaID {get; set;}
        public Producto ProductoDetalle {get; set;}
        public decimal CantidadRequerida {get; set;}
        public decimal ValorUnitario {get; set;}
        public decimal SubTotal {get; set;}


        public int FacturaID {get; set;}
        public Factura Factura {get; set;}

        public int ProductoID {get; set;}
        
    }
}