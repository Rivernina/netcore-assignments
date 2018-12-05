using Forum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Data
{
    public class ForumDbContext  : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options)
        {

        }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
