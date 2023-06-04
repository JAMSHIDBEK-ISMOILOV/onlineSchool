using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnlineSchool.Application.Abstractions;
using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Infrastructure.Persistence
{
	public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			:base(options)
		{
		}

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Science> Sciences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
		}
	}
}

