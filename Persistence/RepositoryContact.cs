using Domain.Contact;
using Application;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Persistence
{
    public class RepositoryContact : IRepository<Contact>
    {
        #region Инициализация данных
        private ContactContext _context;
        public RepositoryContact(ContactContext cc) { _context = cc; }
        #endregion

        #region Реализация интерфейса IRepository
        public string Create(Contact item)
        {
            throw new NotImplementedException();
        }

        public string GetAll()
        {
            var contacts = _context.Contacts;
            return JsonConvert.SerializeObject(contacts);
        }

        public string GetItem(int? id)
        {
            throw new NotImplementedException();
        }

        public string Remove(Contact item)
        {
            throw new NotImplementedException();
        }

        public string Update(Contact item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}