﻿using TMS.core.Domain.Vendors;

namespace TMS.Data.Mapping.Vendors
{
    public partial class VendorMap : TMSEntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            this.ToTable("Vendor");
            this.HasKey(v => v.Id);

            this.Property(v => v.Name).IsRequired().HasMaxLength(400);
            this.Property(v => v.Email).HasMaxLength(400);
            this.Property(v => v.MetaKeywords).HasMaxLength(400);
            this.Property(v => v.MetaTitle).HasMaxLength(400);
            this.Property(v => v.PageSizeOptions).HasMaxLength(200);
        }
    }
}
