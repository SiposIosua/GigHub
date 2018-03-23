namespace GigHub.Core.Models
{
    public class Attendance 
    {
        public Gig Gigs { get; set; }
        public ApplicationUser Attendee { get; set; }

        //[Key]
       // [Column(Order = 1)]
        public int GigId { get; set; }

       // [Key]
        //[Column(Order = 2)]
        public string AttendeeId { get; set; }
    }
}