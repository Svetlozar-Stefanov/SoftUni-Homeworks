﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Models;

namespace TeisterMask.Data
{
    public class TeisterMaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        private static string ConnectionString = @"Server=.\SQLEXPRESS;Database=TeisterMaskDb;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
