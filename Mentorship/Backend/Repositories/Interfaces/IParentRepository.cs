using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;

namespace Mentorship.Backend.Repositories
{
    interface IParentRepository
    {
        void GetParents(ContactId id, out Name parent1, out Name parent2);
    }
}
