﻿using Contacts.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Data
{
    public class ContactsDbContext : IdentityDbContext
    {
        public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUserContact>()
                .HasKey(e => new { e.ContactId, e.ApplicationUserId });

         
             builder
                .Entity<Contact>()
                .HasData(new Contact()
                {
                    Id = 1,
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    PhoneNumber = "+359881223344",
                    Address = "Gotham City",
                    Email = "imbatman@batman.com",
                    Website = "www.batman.com"
                });
            

            base.OnModelCreating(builder);
        }


        public  DbSet<Contact> Contacts { get; set; } 

        public  DbSet<ApplicationUser> ApplicationUsers { get; set; } 

        public  DbSet<ApplicationUserContact> ApplicationUsersContacts { get; set; } 
    }
}


