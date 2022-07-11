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
    }
}