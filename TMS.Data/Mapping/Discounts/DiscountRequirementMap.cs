using TMS.core.Domain.Discounts;

namespace TMS.Data.Mapping.Discounts
{
    public partial class DiscountRequirementMap : TMSEntityTypeConfiguration<DiscountRequirement>
    {
        public DiscountRequirementMap()
        {
            this.ToTable("DiscountRequirement");
            this.HasKey(dr => dr.Id);
        }
    }
}
