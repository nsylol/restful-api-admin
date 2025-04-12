namespace Data.Models;
public class WorkoutType
{
    public int Id { get; set; }
    public string Name { get; set; } // "Йога", "Кроссфит"
    public string Description { get; set; }
    public int CaloriesPerHour { get; set; }
    
    public List<Schedule> Schedules { get; set; } = new();
}