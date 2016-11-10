using TMS.core.Domain.Forums;

namespace TMS.Data.Mapping.Forums
{
    public partial class ForumPostVoteMap : TMSEntityTypeConfiguration<ForumPostVote>
    {
        public ForumPostVoteMap()
        {
            this.ToTable("Forums_PostVote");
            this.HasKey(fpv => fpv.Id);

            this.HasRequired(fpv => fpv.ForumPost)
                .WithMany()
                .HasForeignKey(fpv => fpv.ForumPostId)
                .WillCascadeOnDelete(true);
        }
    }
}
