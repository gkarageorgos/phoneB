namespace PhoneBook.Models
{
    public class EmailType : PhoneBookType
    {
        public ICollection<Email> Emails { get; } = [];
    }
}
