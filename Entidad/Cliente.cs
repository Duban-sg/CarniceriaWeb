using System.ComponentModel.DataAnnotations;
namespace Entidad
{
    public class Cliente:Persona
    {
       public Factura Carrito {get;set;}
       public string Direccion {get;set;}

    }
}