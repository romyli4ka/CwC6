using ContactWebModels;

namespace MyContactManagerServices
{
    public interface IContactService
    {
        Task<IList<Contact>> GetAllAsync();
        Task<Contact?> GetAsync(int id);
        Task<int> AddorUpdateAsync(Contact contact);
        Task<int> DeleteAsync(int id);
        Task<int> DeleteAsync(Contact contact);
        Task<bool> ExistsAsync(int id);

    }
}
