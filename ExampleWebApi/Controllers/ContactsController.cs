using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExampleWebApi.Models;
using ExampleWebApi.Repository;

namespace ExampleWebApi.Controllers
{
    public class ContactsController : ApiController
    {
        private IContactsRepository repository;

        public ContactsController(IContactsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("contacts")]
        public IHttpActionResult Get()
        {
            return Ok(this.repository.GetContact());
        }
    }
}
