using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
             
        }
        public ApplicationDBContext()
            : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QJTH6KA\\SQLEXPRESS;Initial Catalog=CreditCardDB;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public virtual DbSet<CardMasterTypes> CardMasterTypes { get; set; }
        public virtual DbSet<CardDetails> CardDetails { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}
