﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConectarDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DigitalWareEntities : DbContext
    {
        public DigitalWareEntities()
            : base("name=DigitalWareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatCliente> CatCliente { get; set; }
        public virtual DbSet<CatFactura> CatFactura { get; set; }
        public virtual DbSet<CatInventarioP> CatInventarioP { get; set; }
        public virtual DbSet<CatProducto> CatProducto { get; set; }
    }
}
