using TMS.core.Domain.Forums;

namespace TMS.Data.Mapping.Forums
{
    public partial class ForumGroupMap : TMSEntityTypeConfiguration<ForumGroup>
    {
        public ForumGroupMap()
        {
            this.ToTable("Forums_Group");
            this.HasKey(fg => fg.Id);
            this.Property(fg => fg.Name).IsRequired().HasMaxLength(200);
        }
    }
}
