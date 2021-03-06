﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using SmartRent.DataAccess.Models;

namespace SmartRent.DataAccess
{
    public class DatabaseContext : IdentityDbContext
    {
        static DatabaseContext()
        {
            //Database.SetInitializer(new DatabaseContextInitializer());
        }

        public DatabaseContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<ItemEntity> Items { get; set; }

        public DbSet<RentEntity> Rents { get; set; }

        public DbSet<ShopEntity> Shops { get; set; }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }
    }
}