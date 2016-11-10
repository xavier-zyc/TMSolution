using TMS.core.Domain.Catalog;

namespace TMS.Data.Mapping.Catalog
{
    public partial class ManufacturerTemplateMap : TMSEntityTypeConfiguration<ManufacturerTemplate>
    {
        public ManufacturerTemplateMap()
        {
            this.ToTable("ManufacturerTemplate");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired().HasMaxLength(400);
            this.Property(p => p.ViewPath).IsRequired().HasMaxLength(400);
        }
    }
}
