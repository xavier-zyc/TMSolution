using TMS.core.Domain.Shipping;

namespace TMS.Data.Mapping.Shipping
{
    public class WarehouseMap : TMSEntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            this.ToTable("Warehouse");
            this.HasKey(wh => wh.Id);
            this.Property(wh => wh.Name).IsRequired().HasMaxLength(400);
        }
    }
}
