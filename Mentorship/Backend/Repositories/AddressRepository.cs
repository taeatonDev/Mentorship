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
            //Few things we can do here. By returning the result we don't actually need this line. 
            //It will save on memory usage and lower the processing time for this method since it doen't have to continue to the end.
            Address address = new Address();

            switch (id)
            {
                case 1:
                    //instead of assigning the new object, just return it.
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
                    //instead of assigning the new object, just return it.
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
                    //instead of assigning the new object, just return it.
                    address = new Address();
                    break;
            };

            //obsolete
            return address;
        }
    }
}
