using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Models
{
    [Keyless]
    public class LeaugeInClub
    {
        public int LeaugeId { get; set; }
        public int ClubId { get; set; }
    }
}
