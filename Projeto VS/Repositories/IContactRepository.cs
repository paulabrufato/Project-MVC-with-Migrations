using System.Collections.Generic;
using Projeto_VS.Models;

namespace Projeto_VS.Repositories
{
    public interface IContactRepository
    {
        //Criação de métodos
        ContactModel GetById (int id);
        List<ContactModel> GetAll ();
        ContactModel Create (ContactModel contact);
        ContactModel Update (ContactModel contact);
    }
}