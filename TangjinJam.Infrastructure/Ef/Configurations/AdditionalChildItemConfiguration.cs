using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TangjinJam.Infrastructure.Model;

namespace TangjinJam.Infrastructure.Ef.Configurations
{
    class AdditionalChildItemConfiguration : IEntityTypeConfiguration<AdditionalChildItem>
    {
        public void Configure(EntityTypeBuilder<AdditionalChildItem> builder)
        {
            builder.HasKey(o => o.Id);
        }
    }
}
