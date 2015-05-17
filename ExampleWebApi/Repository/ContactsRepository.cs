using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExampleWebApi.Models;

namespace ExampleWebApi.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        public Contact GetContact()
        {
            return new Contact(){FirstName = "Donald", LastName = "Duck"};
        }
    }
}