using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhoneBook.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Το όνομα της εταιρίας είναι υποχρεωτικό.")]
        [StringLength(100)]
        [DisplayName("Όνομα Εταιρίας")]
        public string Name { get; set; } = null!;

        [StringLength(500)]
        [DisplayName("Περιγραφή")]
        public string? Description { get; set; }

        [StringLength(200)]
        [DisplayName("Διεύθυνση")]
        public string? Address { get; set; }

        public ICollection<Customer> Customers { get; } = [];
    }
}
