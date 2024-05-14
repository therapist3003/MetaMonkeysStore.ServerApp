using System.ComponentModel.DataAnnotations;

namespace MetaMonkeysBillingSystem.App.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(10)]
        public string Role { get; set; } = null!; // null! allows to avoid NullReferenceException

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string Username { get; set; } = null!;

        [StringLength(20)]
        public string Password { get; set; } = null!;
    }
}
