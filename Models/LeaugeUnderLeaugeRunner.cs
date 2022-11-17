using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Models
{
    [Keyless]
    public class LeaugeUnderLeaugeRunner
    {
        public int LeaugeId { get; set; }
        public int LeagueRunnerId { get; set; }
    }
}
