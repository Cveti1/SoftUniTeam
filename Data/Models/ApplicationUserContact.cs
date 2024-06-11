using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Contacts.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Contacts.Data.Models
{
    public class ApplicationUserContact
    {

        public string ApplicationUserId { get; set; } = null!;

        [ForeignKey(nameof(ApplicationUserId))]
        [Required]
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public int ContactId { get; set; } 

        [ForeignKey(nameof(ContactId))]
        [Required]
        public Contact Contact { get; set; } = null!;


    }
}


