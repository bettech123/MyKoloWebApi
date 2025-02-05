﻿using Microsoft.EntityFrameworkCore;
using MyKoloWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKoloWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        //DbSets to represent tables
        //Type of generic collection
        //DbSet<T>

        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Savings> Savings { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
