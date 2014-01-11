using System.Collections.Generic;
using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;

namespace Mentorship.Backend.Repositories
{
    interface IChildrenRepository
    {
        List<ChildName> GetChildNames(ContactId id);
    }
}
