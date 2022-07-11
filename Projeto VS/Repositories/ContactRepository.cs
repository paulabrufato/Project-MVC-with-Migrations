using System.Collections.Generic;
using System.Linq;
using Projeto_VS.Data;
using Projeto_VS.Models;

namespace Projeto_VS.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataBaseContext _dataBaseContext;
        public ContactRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        
        public ContactModel GetById(int id)
        {
            return _dataBaseContext.Contacts.FirstOrDefault(x => x.Id == id);
        }

        public List<ContactModel> GetAll()
        {
            return _dataBaseContext.Contacts.ToList();
        }

        public ContactModel Create(ContactModel contact)
        {
            //Salvar no banco de dados
            _dataBaseContext.Contacts.Add(contact);
            _dataBaseContext.SaveChanges();

            return contact;
        }

        public ContactModel Update(ContactModel contact)
        {
            ContactModel contactDb = GetById(contact.Id);
            if(contactDb == null) throw new System.Exception("Erro de atualização de contato!");
            contactDb.Name = contact.Name;
            contactDb.Email = contact.Email;
            contactDb.Phone = contact.Phone;

            _dataBaseContext.Contacts.Update(contactDb);
            _dataBaseContext.SaveChanges();

            return contactDb;
        }
    }
}