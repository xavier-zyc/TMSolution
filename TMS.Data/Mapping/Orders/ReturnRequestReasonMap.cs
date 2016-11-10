using TMS.core.Domain.Orders;

namespace TMS.Data.Mapping.Orders
{
    public partial class ReturnRequestReasonMap : TMSEntityTypeConfiguration<ReturnRequestReason>
    {
        public ReturnRequestReasonMap()
        {
            this.ToTable("ReturnRequestReason");
            this.HasKey(rrr => rrr.Id);
            this.Property(rrr => rrr.Name).IsRequired().HasMaxLength(400);
        }
    }
}
