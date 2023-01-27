using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Policy;
using System;
using InternalErpProject.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InternalErpProject.WebAPI.Data
{
    public class ErpContext : DbContext
    {
        public ErpContext(DbContextOptions<ErpContext> options) : base(options) { }
        public DbSet<PersonModel> People { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PersonModel>()
                .HasData(new List<PersonModel>(){
                    new PersonModel(1, "Artur Gonçalves", 21787938, 89371897, DateTime.Parse("08/12/2001"), 186867, "artur@gmail.com", 263846234, "Ceará", "Fortaleza", false, "Maria", 392139739),
                    new PersonModel(2, "Artur Pereira", 8324238, 123123217, DateTime.Parse("01/04/2004"), 434237, "arturP@gmail.com", 213136234, "Ceará", "Fortaleza", true, "Max", 323354354)
                });
        }
    }
}
