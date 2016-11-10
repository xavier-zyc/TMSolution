using TMS.core.Domain.Affiliates;

namespace TMS.Data.Mapping.Affiliates
{
    public partial class AffiliateMap : TMSEntityTypeConfiguration<Affiliate>
    {
        public AffiliateMap()
        {
            this.ToTable("Affiliate");
            this.HasKey(a => a.Id);

            this.HasRequired(a => a.Address).WithMany().HasForeignKey(x => x.AddressId).WillCascadeOnDelete(false);
        }
    }
}
