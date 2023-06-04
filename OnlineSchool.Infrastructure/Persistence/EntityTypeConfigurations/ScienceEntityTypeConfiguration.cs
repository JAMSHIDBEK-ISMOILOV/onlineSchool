using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ScienceEntityTypeConfiguration : IEntityTypeConfiguration<Science>
    {
        public void Configure(EntityTypeBuilder<Science> builder)
        {
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.Sciences)
                .HasForeignKey(x => x.TeacherId);

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Sciences)
                .HasForeignKey(x => x.StudentId);
        }
    }
}

