﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_MLK
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class connectProjetGSB : DbContext
    {
        public connectProjetGSB()
            : base("name=connectProjetGSB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Laboratoire> Laboratoire { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Secteur> Secteur { get; set; }
        public virtual DbSet<Visiteur> Visiteur { get; set; }
    }
}