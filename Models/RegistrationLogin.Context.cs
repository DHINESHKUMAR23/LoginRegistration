﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginRegistration.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentDBEntities4 : DbContext
    {
        public StudentDBEntities4()
            : base("name=StudentDBEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminDetail> AdminDetails { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<StudentDetail> StudentDetails { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
    }
}
