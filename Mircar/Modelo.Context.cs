﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mircar
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentcarEntities : DbContext
    {
        public RentcarEntities()
            : base("name=RentcarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
<<<<<<< HEAD
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Inspeccion> Inspeccion { get; set; }
        public virtual DbSet<Tipos_Combustibles> Tipos_Combustibles { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<Tipos_Vehiculos> Tipos_Vehiculos { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Renta_Devolucion> Renta_Devolucion { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
=======
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Inspeccion> Inspeccion { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<Renta_Devolucion> Renta_Devolucion { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tipos_Combustibles> Tipos_Combustibles { get; set; }
        public virtual DbSet<Tipos_Vehiculos> Tipos_Vehiculos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
>>>>>>> c981806e37287a70ea3cd98c36cffc654bec212c
    }
}
