namespace Data.Models;
public class Staff
{
    public int Id { get; set; }
    public string Position { get; set; }
    public DateTime HireDate { get; set; }
    public decimal Salary { get; set; }
    
    // Связи
    public int UserID { get; set; }
    public User User { get; set; }
    
    public int ClubID { get; set; }
    public Club Club { get; set; }
    
    public List<Schedule> ConductedSchedules { get; set; } = new();
}