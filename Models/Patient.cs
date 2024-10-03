using System.ComponentModel.DataAnnotations;

namespace Hospital_System.Models
{
    public class Patient
    {
        
        public int Id { get; set; }
        public string Name { get; set; }    
        public DateOnly Appointment { get; set; }
        public TimeOnly TimeOnly { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
