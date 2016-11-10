using TMS.core.Domain.Catalog;

namespace TMS.Data.Mapping.Catalog
{
    public partial class RelatedProductMap : TMSEntityTypeConfiguration<RelatedProduct>
    {
        public RelatedProductMap()
        {
            this.ToTable("RelatedProduct");
            this.HasKey(c => c.Id);
        }
    }
}
