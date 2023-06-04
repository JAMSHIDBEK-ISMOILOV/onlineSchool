using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.BirthDate)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}

