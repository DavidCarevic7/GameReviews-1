using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfDataAccess.Configurations
{
    public class  PostConfiguration : IEntityTypeConfiguration<Post>
    {

        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Title).IsRequired().
            HasMaxLength(50);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Rating).IsRequired().HasMaxLength(1);

            builder.Property(p => p.CreatedOn).HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.PostImageId).IsRequired();


        }
    }
}
