namespace Data.Models;
public class Club
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public TimeSpan OpeningTime { get; set; }
    public TimeSpan ClosingTime { get; set; }
    
    // Связи
    public List<Staff> Staff { get; set; } = new();
    public List<Schedule> Schedules { get; set; } = new();
}