﻿using TMS.core.Domain.Shipping;

namespace TMS.Data.Mapping.Shipping
{
    public partial class ShipmentMap : TMSEntityTypeConfiguration<Shipment>
    {
        public ShipmentMap()
        {
            this.ToTable("Shipment");
            this.HasKey(s => s.Id);

            this.Property(s => s.TotalWeight).HasPrecision(18, 4);

            this.HasRequired(s => s.Order)
                .WithMany(o => o.Shipments)
                .HasForeignKey(s => s.OrderId);
        }
    }
}
