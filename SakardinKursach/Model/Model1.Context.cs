﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SakardinKursach.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class user19Entities1 : DbContext
    {
        public user19Entities1()
            : base("name=user19Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<actions_log> actions_log { get; set; }
        public DbSet<call_assignments> call_assignments { get; set; }
        public DbSet<emergency_calls> emergency_calls { get; set; }
        public DbSet<emergency_teams> emergency_teams { get; set; }
        public DbSet<operators> operators { get; set; }
    }
}
