using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfDataAccess.Configurations
{
    public class CommentConfiguration:IEntityTypeConfiguration<Comment>
    {

        public void Configure(EntityTypeBuilder<Comment> builder) {

            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.UserId).IsRequired();
            builder.Property(c => c.PostId).IsRequired();
            builder.Property(c => c.CreatedOn).HasDefaultValueSql("GETDATE()");
            

        }
    }
}
