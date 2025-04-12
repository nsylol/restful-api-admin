namespace Data.Models;
public class Schedule
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int MaxParticipants { get; set; }
    
    // Связи
    public int ClubId { get; set; }
    public Club Club { get; set; }
    
    public int WorkoutTypeId { get; set; }
    public WorkoutType WorkoutType { get; set; }
    
    public int CoachId { get; set; }
    public Staff Coach { get; set; }
    
    public List<Booking> Bookings { get; set; } = new();
}