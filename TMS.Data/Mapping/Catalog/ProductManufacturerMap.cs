﻿using TMS.core.Domain.Catalog;

namespace TMS.Data.Mapping.Catalog
{
    public partial class ProductManufacturerMap : TMSEntityTypeConfiguration<ProductManufacturer>
    {
        public ProductManufacturerMap()
        {
            this.ToTable("Product_Manufacturer_Mapping");
            this.HasKey(pm => pm.Id);

            this.HasRequired(pm => pm.Manufacturer)
                .WithMany()
                .HasForeignKey(pm => pm.ManufacturerId);


            this.HasRequired(pm => pm.Product)
                .WithMany(p => p.ProductManufacturers)
                .HasForeignKey(pm => pm.ProductId);
        }
    }
}
