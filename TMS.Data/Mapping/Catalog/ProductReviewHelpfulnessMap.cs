﻿using TMS.core.Domain.Catalog;

namespace TMS.Data.Mapping.Catalog
{
    public partial class ProductReviewHelpfulnessMap : TMSEntityTypeConfiguration<ProductReviewHelpfulness>
    {
        public ProductReviewHelpfulnessMap()
        {
            this.ToTable("ProductReviewHelpfulness");
            this.HasKey(pr => pr.Id);

            this.HasRequired(prh => prh.ProductReview)
                .WithMany(pr => pr.ProductReviewHelpfulnessEntries)
                .HasForeignKey(prh => prh.ProductReviewId).WillCascadeOnDelete(true);
        }
    }
}
