namespace Data.Models;
public class Booking
{
    public int Id { get; set; }
    public DateTime BookingTime { get; set; } = DateTime.UtcNow;
    public string Status { get; set; }
    
    // Связи
    public int ScheduleID { get; set; }
    public Schedule Schedule { get; set; }
    
    public int UserID { get; set; }
    public User User { get; set; }
}