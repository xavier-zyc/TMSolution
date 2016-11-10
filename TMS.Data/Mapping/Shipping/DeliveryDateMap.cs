using TMS.core.Domain.Shipping;

namespace TMS.Data.Mapping.Shipping
{
    public class DeliveryDateMap : TMSEntityTypeConfiguration<DeliveryDate>
    {
        public DeliveryDateMap()
        {
            this.ToTable("DeliveryDate");
            this.HasKey(dd => dd.Id);
            this.Property(dd => dd.Name).IsRequired().HasMaxLength(400);
        }
    }
}
