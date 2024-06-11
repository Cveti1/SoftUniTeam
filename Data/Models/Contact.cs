using System.ComponentModel.DataAnnotations;
using static Contacts.Data.DataConstants;

namespace Contacts.Data.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; } 


        [Required]
        [MaxLength(MaxFirstName)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MaxLastName)]
        public string LastName { get; set; } = null!;


        [Required]
        [MaxLength(MaxContactEmail)]
        [EmailAddress]
        public string Email { get; set; } = null!;


        [Required]
        [MaxLength(MaxPhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; } = null!;


         public string? Address { get; set; } = null!;


         [Required]
         public string Website { get; set; } = null!;



         public ICollection<ApplicationUserContact> ApplicationUsersContacts = new List
            <ApplicationUserContact>();


    }
}


