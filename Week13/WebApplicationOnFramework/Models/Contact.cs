using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationOnFramework.Models
{
    public class Contact
    {
        public string Name { get; set; }
    }

    public class ContactManager
    {
        public Contact GetDefaultContact()
        {
            return new Contact()
            {
                Name = "Andrei"
            };
        }
    }
}