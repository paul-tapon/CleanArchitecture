using Core.Domain.Model.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
   

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(e => e.UserId);

            builder.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(e => e.LastModified);

            builder.Property(e => e.Created)
              .IsRequired()
              .HasMaxLength(30);

            builder.HasOne(u => u.CreatedByUser).WithMany();
            builder.HasOne(u => u.LastModifiedByUser).WithMany();

            builder.HasOne(u => u.Organization).WithMany(o => o.Users);

            //builder.HasAlternateKey(u => new { u.Username,u.OrganizationId});


            builder.HasOne(u => u.Organization).WithMany(o => o.Users);
        }
    }

    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organization");

            builder.HasKey(e => e.OrganizationId);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(e => e.LastModified);

            builder.Property(e => e.Created)
              .IsRequired()
              .HasMaxLength(30);

            builder.HasOne(u => u.CreatedByUser).WithMany();
            builder.HasOne(u => u.LastModifiedByUser).WithMany();

            //builder.HasOne(u => u.Organization).WithMany(o => o.Users);
            //builder.HasOne(u => u.Organization).WithMany(o => o.Users);


            //builder.HasAlternateKey(u => new { u.Username,u.OrganizationId});


            //builder.HasOne(u => u.Organization).WithMany(o => o.Users);
        }
    }
}
