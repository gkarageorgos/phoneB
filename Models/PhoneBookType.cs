using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhoneBook.Models
{
    public class PhoneBookType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Τύπος")]
        public string Name { get; set; } = null!;
    }
}
