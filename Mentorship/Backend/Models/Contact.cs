using System.Collections.Generic;
using Mentorship.Backend.Models.StronglyTypedObjects;

namespace Mentorship.Backend.Models
{
    public class Contact
    {
        public ContactId ContactId { get; set; }
        public Name Parent1 { get; set; }
        public Name Parent2 { get; set; }
        public List<ChildName> Children { get; set; }
        public Address PropAddress { get; set; }
    }
}
