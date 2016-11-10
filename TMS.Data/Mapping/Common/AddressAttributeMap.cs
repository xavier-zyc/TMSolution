﻿using TMS.core.Domain.Common;

namespace TMS.Data.Mapping.Common
{
    public partial class AddressAttributeMap : TMSEntityTypeConfiguration<AddressAttribute>
    {
        public AddressAttributeMap()
        {
            this.ToTable("AddressAttribute");
            this.HasKey(aa => aa.Id);
            this.Property(aa => aa.Name).IsRequired().HasMaxLength(400);

            this.Ignore(aa => aa.AttributeControlType);
        }
    }
}
