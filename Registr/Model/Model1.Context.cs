﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registr.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SportEntities2 : DbContext
    {
        public SportEntities2()
            : base("name=SportEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aboniment> Aboniment { get; set; }
        public virtual DbSet<DanniePersonal> DanniePersonal { get; set; }
        public virtual DbSet<Doljnosti> Doljnosti { get; set; }
        public virtual DbSet<InfoZanitia> InfoZanitia { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Kolichistvo> Kolichistvo { get; set; }
        public virtual DbSet<Oplata> Oplata { get; set; }
        public virtual DbSet<Polizovateli> Polizovateli { get; set; }
        public virtual DbSet<SposobOplati> SposobOplati { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipAbonimenta> TipAbonimenta { get; set; }
        public virtual DbSet<Tipzanitia> Tipzanitia { get; set; }
        public virtual DbSet<Zanitie> Zanitie { get; set; }
    }
}
