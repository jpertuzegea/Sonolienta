//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO_DORMISIENTA
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Precio { get; set; }
        public Nullable<int> Categotia { get; set; }
        public Nullable<int> CantidadDisponible { get; set; }
        public byte[] Imagen { get; set; }
        public string ContetType { get; set; }
        public Nullable<byte> Estado { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
    }
}
