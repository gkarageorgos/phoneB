namespace PhoneBook.Models
{
    public class PhoneType : PhoneBookType
    {
        public ICollection<Phone> Phones { get; set; } = [];
    }
}
