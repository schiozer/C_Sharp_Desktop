﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFLibs
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class testesEntitiesDatabase : DbContext
    {
        public testesEntitiesDatabase()
            : base("name=testesEntitiesDatabase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
    
        public virtual int sp_DoYourJob(string whatJob, string cidade, ObjectParameter result)
        {
            var whatJobParameter = whatJob != null ?
                new ObjectParameter("WhatJob", whatJob) :
                new ObjectParameter("WhatJob", typeof(string));
    
            var cidadeParameter = cidade != null ?
                new ObjectParameter("Cidade", cidade) :
                new ObjectParameter("Cidade", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DoYourJob", whatJobParameter, cidadeParameter, result);
        }
    }
}
