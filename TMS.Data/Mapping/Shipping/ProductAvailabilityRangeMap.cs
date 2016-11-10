using TMS.core.Domain.Shipping;

namespace TMS.Data.Mapping.Shipping
{
    public class ProductAvailabilityRangeMap : TMSEntityTypeConfiguration<ProductAvailabilityRange>
    {
        public ProductAvailabilityRangeMap()
        {
            this.ToTable("ProductAvailabilityRange");
            this.HasKey(range => range.Id);
            this.Property(range => range.Name).IsRequired().HasMaxLength(400);
        }
    }
}
