using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Invite
    {
        [Key]
        public int InviteId { get; set; }
        public int UserId { get; set; }
        public int WeddingId { get; set; }
        public Wedding Party { get; set; }
        public User Guest { get; set; }
    }
}