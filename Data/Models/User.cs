using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

public class User
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Имя обязательно")]
    [StringLength(50, MinimumLength = 2)]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Фамилия обязательна")]
    [StringLength(50, MinimumLength = 2)]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Email обязателен")]
    [EmailAddress(ErrorMessage = "Некорректный формат email")]
    [Column(TypeName = "varchar(100)")] // Оптимальный тип для email в БД
    public string Email { get; set; } // Удален дублирующийся Email

    [Phone(ErrorMessage = "Некорректный формат телефона")]
    [Column(TypeName = "varchar(20)")] 
    public string? Phone { get; set; } // Сделал nullable

    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    
    // Навигационные свойства
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public virtual ICollection<Staff> StaffPositions { get; set; } = new List<Staff>();
}