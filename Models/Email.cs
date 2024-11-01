using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhoneBook.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [EmailAddress]
        [DisplayName("Email")]
        public string EmailAddress { get; set; } = null!;

        public int? EmailTypeId { get; set; }
        public EmailType? EmailType { get; set; }

        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;
    }
}
