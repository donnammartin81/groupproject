using System;
using Microsoft.EntityFrameworkCore;

namespace groupproject.Models
{

  public class ResidentDbContext : DbContext
  {
    public ResidentDbContext(DbContextOptions<ResidentDbContext> options) : base(options)
    {

    }
    public DbSet<Resident> Posts { get; set; }
  }
}    