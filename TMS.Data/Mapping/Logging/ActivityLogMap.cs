﻿using TMS.core.Domain.Logging;

namespace TMS.Data.Mapping.Logging
{
    public partial class ActivityLogMap : TMSEntityTypeConfiguration<ActivityLog>
    {
        public ActivityLogMap()
        {
            this.ToTable("ActivityLog");
            this.HasKey(al => al.Id);
            this.Property(al => al.Comment).IsRequired();
            this.Property(al => al.IpAddress).HasMaxLength(200);

            this.HasRequired(al => al.ActivityLogType)
                .WithMany()
                .HasForeignKey(al => al.ActivityLogTypeId);

            this.HasRequired(al => al.Customer)
                .WithMany()
                .HasForeignKey(al => al.CustomerId);
        }
    }
}
