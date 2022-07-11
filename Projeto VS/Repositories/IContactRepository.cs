using System.Collections.Generic;
using Projeto_VS.Models;

namespace Projeto_VS.Repositories
{
    public interface IContactRepository
    {
        //Criação de métodos
        List<ContactModel> GetAll ();
        ContactModel Create(ContactModel contact);
    }
}