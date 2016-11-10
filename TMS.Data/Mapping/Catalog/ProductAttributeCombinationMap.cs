using TMS.core.Domain.Catalog;

namespace TMS.Data.Mapping.Catalog
{
    public partial class ProductAttributeCombinationMap : TMSEntityTypeConfiguration<ProductAttributeCombination>
    {
        public ProductAttributeCombinationMap()
        {
            this.ToTable("ProductAttributeCombination");
            this.HasKey(pac => pac.Id);

            this.Property(pac => pac.Sku).HasMaxLength(400);
            this.Property(pac => pac.ManufacturerPartNumber).HasMaxLength(400);
            this.Property(pac => pac.Gtin).HasMaxLength(400);
            this.Property(pac => pac.OverriddenPrice).HasPrecision(18, 4);

            this.HasRequired(pac => pac.Product)
                .WithMany(p => p.ProductAttributeCombinations)
                .HasForeignKey(pac => pac.ProductId);
        }
    }
}
