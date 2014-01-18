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

            Address address = new Address();

            switch (id)
            {
                case 1:
                    address = new Address
                    {
                        StreetAddress1 = "500 NE 43rd St",
                        StreetAddress2 = "",
                        City = "Kansas City",
                        State = Models.Enums.UsState.MO,
                        ZipCode = 64116
                    };
                    break;
                case 2:
                    address = new Address
                    {
                        StreetAddress1 = "600 NE 43rd St",
                        StreetAddress2 = "",
                        City = "Kansas City",
                        State = Models.Enums.UsState.MO,
                        ZipCode = 64116
                    };
                    break;
                default:
                    address = new Address();
                    break;
            };

            return address;
        }
    }
}
