using TMS.core.Domain.Catalog;

namespace TMS.Data.Mapping.Catalog
{
    public partial class CrossSellProductMap : TMSEntityTypeConfiguration<CrossSellProduct>
    {
        public CrossSellProductMap()
        {
            this.ToTable("CrossSellProduct");
            this.HasKey(c => c.Id);
        }
    }
}
