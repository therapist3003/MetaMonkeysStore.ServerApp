using System.ComponentModel.DataAnnotations;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class Employee
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; } = null!;
        
        [Required]
        [StringLength(10)]
        public string Role { get; set; } = null!; // null! allows to avoid NullReferenceException

        [StringLength(20)]
        public string Password { get; set; } = null!;
    }
}
