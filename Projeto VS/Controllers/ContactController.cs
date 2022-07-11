using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Projeto_VS.Models;
using Projeto_VS.Repositories;

namespace Projeto_VS.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Index()
        {
            List<ContactModel> contacts = _contactRepository.GetAll();
            
            return View(contacts);
        }  

        public IActionResult Create()
        {
            return View();
        }   

        public IActionResult Edit(int id)
        {
            ContactModel contact = _contactRepository.GetById(id);
            return View(contact);
        }  

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(ContactModel contact)
        {
            _contactRepository.Create(contact);
            return RedirectToAction("Index");
        } 

        [HttpPost]
        public IActionResult Update(ContactModel contact)
        {
            _contactRepository.Update(contact);
            return RedirectToAction("Index");
        }  
    }
}