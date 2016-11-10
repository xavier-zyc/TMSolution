﻿using TMS.core.Domain.Forums;

namespace TMS.Data.Mapping.Forums
{
    public partial class PrivateMessageMap : TMSEntityTypeConfiguration<PrivateMessage>
    {
        public PrivateMessageMap()
        {
            this.ToTable("Forums_PrivateMessage");
            this.HasKey(pm => pm.Id);
            this.Property(pm => pm.Subject).IsRequired().HasMaxLength(450);
            this.Property(pm => pm.Text).IsRequired();

            this.HasRequired(pm => pm.FromCustomer)
               .WithMany()
               .HasForeignKey(pm => pm.FromCustomerId)
               .WillCascadeOnDelete(false);

            this.HasRequired(pm => pm.ToCustomer)
               .WithMany()
               .HasForeignKey(pm => pm.ToCustomerId)
               .WillCascadeOnDelete(false);
        }
    }
}
