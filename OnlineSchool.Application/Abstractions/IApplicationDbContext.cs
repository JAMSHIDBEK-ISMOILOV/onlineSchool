using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Application.Abstractions
{
	public interface IApplicationDbContext
	{
        DbSet<Grade> Grades { get; set; }
		DbSet<Teacher> Teachers { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Science> Sciences { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

