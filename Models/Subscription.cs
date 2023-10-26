using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4NET.Models
{
    public class Subscription
    {
        public int FanId { get; set; }
        public string SportClubId { get; set; }
        public Fan Fan { get; set; }
        public SportClub SportClub { get; set; }
    }
}
