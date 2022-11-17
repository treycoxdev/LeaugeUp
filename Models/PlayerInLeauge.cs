using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Models
{
    [Keyless]
    public class PlayerInLeauge
    {
        public int PlayerId { get; set; }
        public int LeaugeId { get; set; }
    }
}
