using System.Collections.Generic;
using System.Linq;
using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;

namespace Mentorship.MiddleWare.Interfaces
{
    interface IContactProvider
    {
        Contact GetContact(ContactId id);
        List<Contact> GetAllContacts();
        IQueryable<Contact> GetQueryableContacts();
    }
}
