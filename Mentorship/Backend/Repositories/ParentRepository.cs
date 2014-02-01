using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;
using System.Linq;

namespace Mentorship.Backend.Repositories
{
    public class ParentRepository : IParentRepository
    {
        //I wanted to show you out Params, not something you will see often but it is cool
        public void GetParents(ContactId id, out Name parent1, out Name parent2)
        {
            switch (id)
            {
                case 1:
                    parent1 = new Name
                    {
                        FirstName = "Timothy",
                        MiddleName = "Andy",
                        LastName = "Eaton"
                    };
                    parent2 = new Name
                    {
                        FirstName = "Erin",
                        MiddleName = "Lynette",
                        LastName = "Eaton"
                    };
                    break;
                case 2:
                    parent1 = new Name
                    {
                        FirstName = "Darren",
                        LastName = "Rogers"
                    };
                    parent2 = new Name
                    {
                        FirstName = "Katie",
                        MiddleName = "JoeAnne",
                        LastName = "Rogers"
                    };
                    break;
                default:
                    parent1 = new Name();
                    parent2 = new Name();
                    break;
            }
        }

        
    }
}
