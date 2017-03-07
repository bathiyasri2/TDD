using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDD.Repositiry
{
    public interface IContactRepository
    {

        void CreateNewContact(Contact ContactToCreate);
        void DeleteContact(int id);

        Contact GetContactById(int id);

        IEnumerable<Contact> GetAllContacts();

        int SaveChanges(); 




    }

    public class EfContactReporsitory : IContactRepository
    {

        public void CreateNewContact(Contact ContactToCreate)
        {
            
        }

        public void DeleteContact(int id)
        {
        
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return new List<Contact>(); 
        }

        public Contact GetContactById(int id)
        {
            return new Contact();
        }

        public int SaveChanges()
        {
            return 1;
        }
    }

   

    public class Contact
    {
        public int Id { get; set; }
        public string  Name { get; set; }
    }
}