using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Models
{
    [Keyless]
    public class SessionInLeauge
    {
        public int SessionId { get; set; }
        public int LeaugeId { get; set; }
    }
}
