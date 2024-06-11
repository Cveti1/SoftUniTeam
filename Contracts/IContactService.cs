using Contacts.Models;
namespace Contacts.Contracts
{
    public interface IContactService
    {
        Task AddContact(AddContactFormModel contact, string userId);

        Task AddContactToMy(string userId, MyContactViewModel contact);

        Task<AddContactFormModel> GetAddContactModel();

        Task<IEnumerable<ContactsViewModel>> GetAllContacts();

        Task<IEnumerable<MyContactViewModel>> GetMyContacts(string userId);

        Task<MyContactViewModel> GetContactById(int id);

     //   Task LeaveSeminar(string userId, JoinSeminarViewModel seminar);

       // Task<SeminarDetailsViewModel> GetSeminarDetails(int id);

     //   Task<AddSeminarViewModel> GetSeminarToEdit(int id);
      //  Task<Seminar> FindAsync(int id);

      //  Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();
     //   Task EditSeminarAsync(AddSeminarViewModel model, Seminar seminarToEdit);
      //  Task DeleteSeminarAsync(Seminar seminar);
    }
}
