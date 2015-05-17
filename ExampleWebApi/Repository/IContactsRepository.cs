using ExampleWebApi.Models;

namespace ExampleWebApi.Repository
{
    public interface IContactsRepository
    {
        Contact GetContact();
    }
}