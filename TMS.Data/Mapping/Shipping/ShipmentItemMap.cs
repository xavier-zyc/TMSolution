using TMS.core.Domain.Shipping;

namespace TMS.Data.Mapping.Shipping
{
    public partial class ShipmentItemMap : TMSEntityTypeConfiguration<ShipmentItem>
    {
        public ShipmentItemMap()
        {
            this.ToTable("ShipmentItem");
            this.HasKey(si => si.Id);

            this.HasRequired(si => si.Shipment)
                .WithMany(s => s.ShipmentItems)
                .HasForeignKey(si => si.ShipmentId);
        }
    }
}
