using Microsoft.EntityFrameworkCore;
using SetsisB2C_Core.Entities;
using SetsisB2C_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SetsisB2C_DataAccess.Concrete
{
    public class AdminDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.30.30.152;Database=Abaci_Giyim; User Id=serkan;Password=set238**!!");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim>  operationClaims { get; set; }
        public DbSet<UserOperationClaim>  UserOperationClaims { get; set; }
    }
}
