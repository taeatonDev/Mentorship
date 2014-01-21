using Mentorship.Backend.Repositories;

namespace Mentorship
{
    public static class FakeDiConfiguration
    {
        private static AddressRepository _addressRepository;
        private static ChildrenRepository _childrenRepository;
        private static ParentRepository _parentRepository;

        public static void Configure()
        {
            _addressRepository = new AddressRepository();
            _childrenRepository = new ChildrenRepository();
            _parentRepository = new ParentRepository();
        }

        public static AddressRepository GetAddressRepository()
        {
            return _addressRepository;
        }

        public static ChildrenRepository GetChildrenRepository()
        {
            return _childrenRepository;
        }

        public static ParentRepository GetParentRepository()
        {
            return _parentRepository;
        }

        //Ok so here we have three repo's being established, but we don't have the contact provider being done. 
        //From what is here you should be able to easily duplicate what is going on and create a GetContactProvider method.
        //Flip to the Contact Provider.
    }
}
