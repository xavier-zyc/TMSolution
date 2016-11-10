﻿using TMS.core.Domain.Logging;

namespace TMS.Data.Mapping.Logging
{
    public partial class LogMap : TMSEntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            this.ToTable("Log");
            this.HasKey(l => l.Id);
            this.Property(l => l.ShortMessage).IsRequired();
            this.Property(l => l.IpAddress).HasMaxLength(200);

            this.Ignore(l => l.LogLevel);

            this.HasOptional(l => l.Customer)
                .WithMany()
                .HasForeignKey(l => l.CustomerId)
            .WillCascadeOnDelete(true);

        }
    }
}
