using ContactManagementApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ContactManagementApp.Controllers
{
    public class ContactsController : Controller
    {
        // Static list to store contacts (in-memory storage)
        private static List<Contact> contacts = new List<Contact>();

        // Display all contacts
        public IActionResult Index()
        {
            return View(contacts);
        }

        // Show form to create a new contact
        public IActionResult Create()
        {
            return View();
        }

        // Handle form submission to create a new contact
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            contact.Id = contacts.Count + 1;
            contacts.Add(contact);
            return RedirectToAction(nameof(Index));
        }

        // Show form to edit an existing contact
        public IActionResult Edit(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // Handle form submission to edit an existing contact
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            var existingContact = contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                existingContact.Name = contact.Name;
                existingContact.Email = contact.Email;
                existingContact.Phone = contact.Phone;
            }
            return RedirectToAction(nameof(Index));
        }

        // Delete a contact
        public IActionResult Delete(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contacts.Remove(contact);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
