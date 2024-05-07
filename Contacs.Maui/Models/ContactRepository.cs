using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacs.Maui.Models
{
    internal static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            // edw zoun ta DATA
            new Contact { ContactID =1, Name ="chris",Email = "2223522"},


            new Contact { ContactID=2, Name ="mark",Email = "5235"},

            new Contact { ContactID=3, Name ="steve",Email = "5354"},

            new Contact { ContactID=4, Name ="ann",Email = "4232545"},
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById (int id)
        {
            var contact =  _contacts.FirstOrDefault(x => x.ContactID == id);
            if(contact != null)
            {
                return new Contact
                {
                    ContactID = contact.ContactID,
                    Name = contact.Name,
                    Email = contact.Email,
                };
            }
            return null;
        }

        public static void UpdateContact (int ContactID, Contact contact)
        {
            if (ContactID != contact.ContactID) return;

            var ContactToUpdate = _contacts.FirstOrDefault(x => x.ContactID == ContactID);
            if (ContactToUpdate != null)
            {
                ContactToUpdate.Name = contact.Name;
                ContactToUpdate.Email = contact.Email;
            }

        }
    }
}
