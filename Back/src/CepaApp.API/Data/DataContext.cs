using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CepaApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CepaApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        public DbSet<Account> Accounts { get; set; }
    }
}