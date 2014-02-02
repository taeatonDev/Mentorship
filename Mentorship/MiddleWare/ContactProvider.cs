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
            //RESPONSE
            //On it.  For my own edification and education, why is it you hate this?
        public  static ContactProvider  GetContractProvider()
        {
            return new ContactProvider();
        }

        public Contact GetContact(ContactId id)
        {
            Name p1;
            Name p2;

            //Side Note, only because I don't recall if we discussed it. While this is possible, it is a bad coding practice and is what we call Code Smell. Google that term.
                //RESPONSE
                //We talked about code smell.  I think this is a part that you wrote specifically to show me what it might look like and to show what using out parameters looks like.
                //I wouldn't have done it this way mostly because I didn't know it was possible to do.
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
                //RESPONSE
                //I keep forgetting about the magical variable type of var.  VB doesn't have anything like that so I'm not used to using it.
                //I'll try my best to keep this in mind.
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
