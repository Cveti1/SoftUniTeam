using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static Contacts.Data.DataConstants;

namespace Contacts.Models
{
	public class AddContactFormModel
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(MaxFirstName, MinimumLength = MinFirstName)]
		[Display(Name = "First Name")]
		public string FirstName { get; set; } = null!;

		[Required]
		[StringLength(MaxLastName, MinimumLength = MinLastName)]
		[Display(Name = "LastName")]
		public string LastName { get; set; } = null!;


		[Required]
		[StringLength(MaxContactEmail, MinimumLength = MinContactEmail)]
		[Display(Name = "Email")]
		[EmailAddress]
		public string Email { get; set; } = null!;


		[Required]
		[StringLength(MaxPhoneNumber, MinimumLength = MinPhoneNumber)]
		[Display(Name = "PhoneNumber")]
		[Phone]
		public string PhoneNumber { get; set; } = null!;


		[Display(Name = "Address")]
		public string? Address { get; set; } = null!;

		


		[Required]
		[RegularExpression(ContactWebsiteRegex)]
		[Display(Name = "Website")]
		public string Website { get; set; } = null!;
	}
}
