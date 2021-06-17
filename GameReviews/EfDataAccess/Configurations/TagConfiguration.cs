using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfDataAccess.Configurations
{
    public class TagConfiguration:IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder) {
            builder.Property(r => r.Name).IsRequired();
            builder.HasIndex(r => r.Name).IsUnique();
            builder.Property(r => r.CreatedOn).HasDefaultValueSql("GETDATE()");
        }
    }
}
