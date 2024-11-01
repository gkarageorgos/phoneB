using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhoneBook.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("Τηλέφωνο")]
        public string PhoneNumber { get; set; } = null!;

        public int PhoneCodeId { get; set; }
        public PhoneCode PhoneCode { get; set; } = null!;

        public int PhoneTypeId { get; set; }
        public PhoneType PhoneType { get; set; } = null!;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
