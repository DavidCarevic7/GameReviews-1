using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfDataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Email)

                .HasMaxLength(50)
                .IsRequired();



            builder.Property(u => u.FirstName)
               .HasMaxLength(30)
               .IsRequired();
            builder.Property(u => u.LastName)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(u => u.Password).HasMaxLength(30)
                .IsRequired();

            
            
            builder.Property(u => u.CreatedOn).HasDefaultValueSql("GETDATE()");

            builder.Property(u => u.RoleId).IsRequired();


        }
    }
}
