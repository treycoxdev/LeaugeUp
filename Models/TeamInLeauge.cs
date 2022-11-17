using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Models
{
    [Keyless]
    public class TeamInLeauge
    {
        public int TeamId { get; set; }
        public int LeaugeId { get; set; }
    }
}
