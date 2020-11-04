using System;
using System.ComponentModel.DataAnnotations;
namespace Entidad
{
    public class ImagenProducto
    {
        public int ImagenProductoID {get;set;}
        public Byte Imagen {get;set;}


        //para la relacion
        public Producto Producto {get;set;}
        public int ProductoID {get;set;} 
    }
}