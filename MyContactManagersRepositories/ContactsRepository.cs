﻿using ContactWebModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactManagersRepositories
{
    public class ContactsRepository : IContactsRepository
    {
        public async Task<int> AddorUpdateAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Contact?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
