﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoTeste2017
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class oc2017Entities : DbContext
    {
        public oc2017Entities()
            : base("name=oc2017Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cidade> cidade { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<pais> pais { get; set; }
        public virtual DbSet<representante> representante { get; set; }
    }
}
