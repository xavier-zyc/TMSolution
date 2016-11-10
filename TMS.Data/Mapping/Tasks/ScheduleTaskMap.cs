using TMS.core.Domain.Tasks;

namespace TMS.Data.Mapping.Tasks
{
    public partial class ScheduleTaskMap : TMSEntityTypeConfiguration<ScheduleTask>
    {
        public ScheduleTaskMap()
        {
            this.ToTable("ScheduleTask");
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.Type).IsRequired();
        }
    }
}
