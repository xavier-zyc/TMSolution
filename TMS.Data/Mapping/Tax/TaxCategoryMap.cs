using TMS.core.Domain.Tax;

namespace TMS.Data.Mapping.Tax
{
    public class TaxCategoryMap : TMSEntityTypeConfiguration<TaxCategory>
    {
        public TaxCategoryMap()
        {
            this.ToTable("TaxCategory");
            this.HasKey(tc => tc.Id);
            this.Property(tc => tc.Name).IsRequired().HasMaxLength(400);
        }
    }
}
