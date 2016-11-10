using TMS.core.Domain.Topics;

namespace TMS.Data.Mapping.Topics
{
    public class TopicMap : TMSEntityTypeConfiguration<Topic>
    {
        public TopicMap()
        {
            this.ToTable("Topic");
            this.HasKey(t => t.Id);
        }
    }
}
