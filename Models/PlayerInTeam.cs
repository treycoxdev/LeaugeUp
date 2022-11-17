using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Models
{
    [Keyless]
    public class PlayerInTeam
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
    }
}
