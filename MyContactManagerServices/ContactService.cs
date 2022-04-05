using ContactWebModels;
using MyContactManagersRepositories;

namespace MyContactManagerServices
{
    public class ContactsService : IContactService
    {
        private IContactsRepository _contactsRepository;

        public ContactsService(IContactsRepository contactsRepo)
        {
            _contactsRepository = contactsRepo;
        }

        public async Task<IList<Contact>> GetAllAsync()
        {
            return await _contactsRepository.GetAllAsync();
        }

        public async Task<Contact?> GetAsync(int id)
        {
            return await _contactsRepository.GetAsync(id);
        }

        public async Task<int> AddOrUpdateAsync(Contact contact)
        {
            return await _contactsRepository.AddOrUpdateAsync(contact);
        }

        public async Task<int> DeleteAsync(Contact contact)
        {
            return await _contactsRepository.DeleteAsync(contact);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _contactsRepository.DeleteAsync(id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _contactsRepository.ExistsAsync(id);
        }
    }
}

/*
     public class ContactsRepository : IContactsRepository
    {

        private MyContactManagerDbContext _context;

        public ContactsRepository(MyContactManagerDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Contact>> GetAllAsync()
        {
            var result = await _context.Contacts.Include(x => x.State).AsNoTracking().ToListAsync();
            return result.OrderBy(x=> x.LastName).ThenBy(x=> x.FirstName).ToList();
        }

        public async Task<Contact?> GetAsync(int id)
        {
            return await _context.Contacts.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

       
           private async Task<int> Insert(Contact contact)
        {
            await GetExistingStateReference(contact);
             await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            return contact.Id;
        }

       private async Task GetExistingStateReference(Contact contact)
        {
            var existingState= await _context.Contacts.SingleOrDefaultAsync(x => x.Id == contact.StateId);
            if (existingState is not null)
            {
                contact.State = existingState;

            }


        }


        private async Task<int> Update(Contact contact)
        {
            var existingcontact= await _context.Contacts.SingleOrDefaultAsync(x=>x.Id == contact.Id);
            if (existingcontact is null) throw new Exception("Contact not found");

            existingcontact.Birthday = contact.Birthday;
            existingcontact.FirstName = contact.FirstName;
            existingcontact.LastName = contact.LastName;
           // existingcontact.State = contact.State;
            existingcontact.City= contact.City;
            existingcontact.Email= contact.Email;
            existingcontact.PhonePrimary= contact.PhonePrimary;
            existingcontact.PhoneSecondary= contact.PhoneSecondary;
            existingcontact.StreetAddress1= contact.StreetAddress1;
            existingcontact.StreetAddress2= contact.StreetAddress2;
            existingcontact.UserId= contact.UserId; 
            existingcontact.UserId=contact.UserId;
         



            await _context.SaveChangesAsync();
            return contact.Id;
        }

        public async Task<int> AddOrUpdateAsync(Contact contact)
        {
            if (contact.Id > 0)
            {
                return await Update(contact);
            }
            return await Insert(contact);
        }

        public async Task<int> DeleteAsync(int id)
        {
           var existinngContact = await _context.Contacts.SingleOrDefaultAsync(x=>x.Id == id);
            if (existinngContact is null) throw new Exception("Can not delete ");
            
            await Task.Run(() => { _context.Contacts.Remove(existinngContact); });
            await _context.SaveChangesAsync();
            
            
            return id;
        }

        public async Task<int> DeleteAsync(Contact contact)
        {
            return await DeleteAsync(contact.Id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
           return await _context.Contacts.AsNoTracking().AnyAsync(x=> x.Id==id);
        }

       
    }
}

  
 */