using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Models
{
    [Keyless]
    public class LeaugeRunnerInClub
    {
        public int LeaugeRunnerId{ get; set;} 
        public int ClubId{ get; set;}
    }
}
