using TMS.core.Domain.Messages;

namespace TMS.Data.Mapping.Messages
{
    public partial class NewsLetterSubscriptionMap : TMSEntityTypeConfiguration<NewsLetterSubscription>
    {
        public NewsLetterSubscriptionMap()
        {
            this.ToTable("NewsLetterSubscription");
            this.HasKey(nls => nls.Id);

            this.Property(nls => nls.Email).IsRequired().HasMaxLength(255);
        }
    }
}
