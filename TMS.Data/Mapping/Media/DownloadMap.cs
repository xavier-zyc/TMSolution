using TMS.core.Domain.Media;

namespace TMS.Data.Mapping.Media
{
    public partial class DownloadMap : TMSEntityTypeConfiguration<Download>
    {
        public DownloadMap()
        {
            this.ToTable("Download");
            this.HasKey(p => p.Id);
            this.Property(p => p.DownloadBinary).IsMaxLength();
        }
    }
}
