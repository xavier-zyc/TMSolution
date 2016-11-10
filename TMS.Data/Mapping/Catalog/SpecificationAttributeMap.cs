using TMS.core.Domain.Catalog;

namespace TMS.Data.Mapping.Catalog
{
    public partial class SpecificationAttributeMap : TMSEntityTypeConfiguration<SpecificationAttribute>
    {
        public SpecificationAttributeMap()
        {
            this.ToTable("SpecificationAttribute");
            this.HasKey(sa => sa.Id);
            this.Property(sa => sa.Name).IsRequired();
        }
    }
}
