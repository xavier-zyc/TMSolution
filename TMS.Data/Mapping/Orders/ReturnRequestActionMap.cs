using TMS.core.Domain.Orders;

namespace TMS.Data.Mapping.Orders
{
    public partial class ReturnRequestActionMap : TMSEntityTypeConfiguration<ReturnRequestAction>
    {
        public ReturnRequestActionMap()
        {
            this.ToTable("ReturnRequestAction");
            this.HasKey(rra => rra.Id);
            this.Property(rra => rra.Name).IsRequired().HasMaxLength(400);
        }
    }
}
