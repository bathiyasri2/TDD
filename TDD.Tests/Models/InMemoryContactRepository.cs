using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Repositiry;

namespace TDD.Tests.Models
{
    class InMemoryContactRepository : IContactRepository
    {
        private List<Contact> db = new List<Contact>();
        public Exception ExceptionToThrow { get; set; }
        public void CreateNewContact(Contact ContactToCreate)
        {


            db.Add(ContactToCreate);
        }

        public void DeleteContact(int id)
        {
            db.Remove(GetContactById(id));
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return db;
        }

        public Contact GetContactById(int id)
        {
            return db.FirstOrDefault(t => t.Id == id);
        }

        public int SaveChanges()
        {
            return 1;
        }

        public void Savechanges(Contact ContactToUpdate)
        {
            foreach (Contact contact in db)
            {
                if (contact.Id == ContactToUpdate.Id)
                {
                    db.Remove(contact);
                    db.Add(ContactToUpdate);
                    break;
                }
            }

        }

    }
}
