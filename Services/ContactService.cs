using Contacts.Contracts;
using Contacts.Data;
using Contacts.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Contacts.Data.Models;

namespace Contacts.Services
{
    public class ContactService : IContactService
    {

        private readonly ContactsDbContext data;

        public ContactService(ContactsDbContext _data)
        {
            data = _data;
        }


        public async Task AddContact(AddContactFormModel contact, string userId)
        {
		
			var newContact = new Contact()
			{
				FirstName = contact.FirstName,
                LastName = contact.LastName,
                Address = contact.Address,
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber,
                Website = contact.Website

			};

			await data.Contacts.AddAsync(newContact);
			await data.SaveChangesAsync();
		}
        

        public async Task AddContactToMy(string userId, MyContactViewModel contact)
        {
	        bool alreadyAdded = await data.ApplicationUsersContacts
		        .AnyAsync(sp => sp.ApplicationUserId == userId && sp.ContactId == contact.Id);

	        if (alreadyAdded == false)
	        {
		        var newContact = new ApplicationUserContact()
		        {
			        ApplicationUserId = userId,
			        ContactId = contact.Id,
		        };

		        await data.ApplicationUsersContacts.AddAsync(newContact);
		        await data.SaveChangesAsync();
	        }
        }

        public async Task<AddContactFormModel> GetAddContactModel()
        {
            
	        var model = new AddContactFormModel();
	        return model;
		}
    
        public async Task<IEnumerable<ContactsViewModel>> GetAllContacts()
        {
            return await data.Contacts
                .Select(s => new ContactsViewModel
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Address = s.Address,
                    Email = s.Email,
                    PhoneNumber = s.PhoneNumber, 
                    Website = s.Website
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<MyContactViewModel>> GetMyContacts(string userId)
        {
            return await data.ApplicationUsersContacts
                .Where(ps => ps.ApplicationUserId == userId)
                .Select(s => new MyContactViewModel
                {
                    Id=s.ContactId,
                    FirstName = s.Contact.FirstName,
                    LastName = s.Contact.LastName,
                    Address = s.Contact.Address,
                    Email = s.Contact.Email,
                    PhoneNumber = s.Contact.PhoneNumber,
                    Website = s.Contact.Website
                }).ToListAsync();

        }

        public async Task<MyContactViewModel> GetContactById(int id)
        {
            return await data.Contacts
                .Where(s => s.Id == id)
                .Select(s => new MyContactViewModel
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Address = s.Address,
                    Email = s.Email,
                    PhoneNumber = s.PhoneNumber,
                    Website = s.Website
                }).FirstOrDefaultAsync();
        }


    }
}

