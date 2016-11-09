using TMS.core.Caching;
using TMS.core.Infrastructure;
using TMS.Services.Tasks;

namespace TMS.Services.Caching
{
    /// <summary>
    /// Clear cache schedueled task implementation
    /// </summary>
    public partial class ClearCacheTask : ITask
    {
        /// <summary>
        /// Executes a task
        /// </summary>
        public void Execute()
        {
            var cacheManager = EngineContext.Current.ContainerManager.Resolve<ICacheManager>("TMS_cache_static");
            cacheManager.Clear();
        }
    }
}
