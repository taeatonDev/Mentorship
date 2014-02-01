using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;

namespace Mentorship.Backend.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        public Address GetAddress(ContactId id)
        {
            switch (id)
            {
                case 1:
                    return new Address
                    {
                        StreetAddress1 = "500 NE 43rd St",
                        StreetAddress2 = "",
                        City = "Kansas City",
                        State = Models.Enums.UsState.MO,
                        ZipCode = 64116
                    };
                case 2:
                    return new Address
                    {
                        StreetAddress1 = "600 NE 43rd St",
                        StreetAddress2 = "",
                        City = "Kansas City",
                        State = Models.Enums.UsState.MO,
                        ZipCode = 64116
                    };
                default:
                    return new Address();
            };


        }
    }
}
