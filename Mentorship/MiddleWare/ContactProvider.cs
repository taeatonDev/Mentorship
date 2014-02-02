using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;
using Mentorship.Backend.Repositories;
using Mentorship.MiddleWare.Interfaces;

namespace Mentorship.MiddleWare
{
    public class ContactProvider : IContactProvider
    {
        private readonly IParentRepository _getParentsById;
        private readonly IAddressRepository _getAddressById;
        private readonly IChildrenRepository _getChildrenById;

        public ContactProvider()
        {
            _getParentsById = FakeDiConfiguration.GetParentRepository();
            _getAddressById = FakeDiConfiguration.GetAddressRepository();
            _getChildrenById = FakeDiConfiguration.GetChildrenRepository();
        }

        // I actually kind of hate this, but for now it is fine. In the next project we will be implementing Structure Map. Might want to read up on it.
        public  static ContactProvider  GetContractProvider()
        {
            return new ContactProvider();
        }

        public Contact GetContact(ContactId id)
        {
            Name p1;
            Name p2;

            //Side Note, only because I don't recall if we discussed it. While this is possible, it is a bad coding practice and is what we call Code Smell. Google that term.
            _getParentsById.GetParents(id, out p1, out p2);

            return new Contact
                        {
                            ContactId = id,
                            Parent1 = p1,
                            Parent2 = p2,
                            PropAddress = _getAddressById.GetAddress(id),
                            Children = _getChildrenById.GetChildNames(id)
                        };
        }

        public List<Contact> GetAllContacts()
        {
            //var
            List<Contact> contacts = new List<Contact>();

            //var on int i = 1;
            for (int i = 1; i <= 2; i++)
            {
                contacts.Add(GetContact(i));
            }

            return contacts;
        }

        public IQueryable<Contact> GetQueryableContacts()
        {
            //var
            List<Contact> contacts = GetAllContacts();
            return contacts.AsQueryable();
        }
    }
}
