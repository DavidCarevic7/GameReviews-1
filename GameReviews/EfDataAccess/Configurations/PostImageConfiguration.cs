using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfDataAccess.Configurations
{
    public class PostImageConfiguration : IEntityTypeConfiguration<PostImage>
    {

        public void Configure(EntityTypeBuilder<PostImage> builder)
        {
            builder.Property(pi => pi.ImageName).IsRequired();
            builder.Property(pi=> pi.CreatedOn).HasDefaultValueSql("GETDATE()");


        }
    }
}
