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

        public IActionResult Edit()
        {
            return View();
        }  

        public IActionResult Update()
        {
            return View();
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
    }
}