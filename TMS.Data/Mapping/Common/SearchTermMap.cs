using TMS.core.Domain.Common;

namespace TMS.Data.Mapping.Common
{
    public partial class SearchTermMap : TMSEntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
