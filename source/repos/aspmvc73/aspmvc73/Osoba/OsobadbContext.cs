﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace aspmvc73.Osoba
{
    public partial class OsobadbContext : DbContext
    {
        public OsobadbContext()
        {
        }

        public OsobadbContext(DbContextOptions<OsobadbContext> opcije)
            : base(opcije)
        {
        }

        public virtual DbSet<Osoba> Osobe { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
           
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.Property(e => e.Telefon).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}