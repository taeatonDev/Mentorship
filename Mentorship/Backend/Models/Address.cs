using Mentorship.Backend.Models.Enums;

namespace Mentorship.Backend.Models
{
    public class Address
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public UsState State  { get; set; }
        public int ZipCode { get; set; }
    }
}
