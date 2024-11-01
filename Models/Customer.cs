using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhoneBook.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        [DisplayName("Όνομα")]
        public string? Name { get; set; }

        [StringLength(100)]
        [DisplayName("Επίθετο")]
        public string? Surname { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                var fullname = $"{Name} {Surname}";
                if (string.IsNullOrWhiteSpace(fullname))
                {
                    fullname = "Δεν υπάρχει Όνομα";
                }
                return fullname.Trim();
            }
        }

        [StringLength(200)]
        [DisplayName("Σημειώσεις")]
        public string? Notes { get; set; }

        [DisplayName("Τηλέφωνα")]
        public ICollection<Phone> Phones { get; set; } = [];

        public ICollection<Email> Emails { get; set; } = [];

        [DisplayName("Εταιρεία")]
        public int? CompanyId { get; set; }
        [DisplayName("Εταιρεία")]
        public Company? Company { get; set; }
    }
}
