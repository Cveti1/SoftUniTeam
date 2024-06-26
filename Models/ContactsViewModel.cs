﻿
namespace Contacts.Models

{
    public class ContactsViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Address { get; set; } = null!;
        public string Website { get; set; } = null!;

        
    }
}
