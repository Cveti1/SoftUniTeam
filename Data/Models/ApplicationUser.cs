using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using static Contacts.Data.DataConstants;

namespace Contacts.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
       
         public ICollection<ApplicationUserContact> ApplicationUsersContacts = new List
         <ApplicationUserContact>();

    }
}





  
   
    
