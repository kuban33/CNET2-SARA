﻿using Microsoft.EntityFrameworkCore;
using PersonModel;

namespace PersonData;

public class PeopleContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Contract> Contracts { get; set; }

    public DbSet<LegalEntity> LegalEntities { get; set; }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=C:\Users\Virtualpro\source\repos\CNET2-SARA\CNET2\people.db");

    //moznost detailni konfigurace db
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);
    //}

    //PM console
    //Install-Package Microsoft.EntityFrameworkCore.Tools
    //set as startup project
    //add-migration "init"
    //vytvoreno migrations
    //update-database

}
