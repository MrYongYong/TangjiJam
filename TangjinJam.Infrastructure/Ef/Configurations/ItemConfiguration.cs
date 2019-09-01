
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TangjinJam.Infrastructure.Model;

namespace TangjinJam.Infrastructure.Ef.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(o => o.Id);
            builder.OwnsOne(o =>
                o.ItemDetail,
                detail =>
                {
                    detail.Property(o => o.Price);
                    detail.Property(o => o.Brand);
                    detail.Property(o => o.IsBuy);
                }
            );
        }
    }
}
