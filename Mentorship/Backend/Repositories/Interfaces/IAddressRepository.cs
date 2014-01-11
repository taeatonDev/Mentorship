using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;

namespace Mentorship.Backend.Repositories
{
    interface IAddressRepository
    {
        Address GetAddress(ContactId id);
    }
}
