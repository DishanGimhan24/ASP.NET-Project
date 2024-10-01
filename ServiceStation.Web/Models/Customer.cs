using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("Full Name")]
        [StringLength(200)]
        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
