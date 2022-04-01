using ContactWebModels;

namespace MyContactManagerServices
{
    public class ContactService : IContactService
    {
        public Task<int> AddorUpdateAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
