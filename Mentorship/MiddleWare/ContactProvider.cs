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
            FakeDiConfiguration.Configure();
            _getParentsById = FakeDiConfiguration.GetParentRepository();
            _getAddressById = FakeDiConfiguration.GetAddressRepository();
            _getChildrenById = FakeDiConfiguration.GetChildrenRepository();
        }

        public Contact GetContact(ContactId id)
        {
            Name p1;
            Name p2;
            _getParentsById.GetParents(id, out p1, out p2);

            return new Contact
                        {
                            ContactId = id,
                            Parent1 = p1,
                            Parent2 = p2,
                            PropAddress = _getAddressById.GetAddress(id),
                            //Children = _getChildrenById.GetChildNames(id)
                        };
        }

        public List<Contact> GetAllContacts()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetQueryableContacts()
        {
            throw new NotImplementedException();
        }
    }
}
