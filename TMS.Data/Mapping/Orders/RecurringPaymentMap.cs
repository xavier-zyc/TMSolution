﻿using TMS.core.Domain.Orders;

namespace TMS.Data.Mapping.Orders
{
    public partial class RecurringPaymentMap : TMSEntityTypeConfiguration<RecurringPayment>
    {
        public RecurringPaymentMap()
        {
            this.ToTable("RecurringPayment");
            this.HasKey(rp => rp.Id);

            this.Ignore(rp => rp.NextPaymentDate);
            this.Ignore(rp => rp.CyclesRemaining);
            this.Ignore(rp => rp.CyclePeriod);



            //this.HasRequired(rp => rp.InitialOrder).WithOptional().Map(x => x.MapKey("InitialOrderId")).WillCascadeOnDelete(false);
            this.HasRequired(rp => rp.InitialOrder)
                .WithMany()
                .HasForeignKey(o => o.InitialOrderId)
                .WillCascadeOnDelete(false);
        }
    }
}
