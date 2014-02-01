using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mentorship.Backend.Models;
using Mentorship.Backend.Models.StronglyTypedObjects;

namespace Mentorship.Backend.Repositories
{
    public class ChildrenRepository : IChildrenRepository
    {
        public List<ChildName> GetChildNames(ContactId id)
        {
            List<ChildName> children = new List<ChildName>();
            switch(id)
            {
                case 1:
                    children.Add(new ChildName { FirstName = "Billy", MiddleName = "Edgar", LastName = "Eaton", Age = 12 });
                    children.Add(new ChildName { FirstName = "Gina", MiddleName = "Ray", LastName = "Eaton", Age = 4 });
                    children.Add(new ChildName { FirstName = "Ralph", MiddleName = "Wiggum", LastName = "Eaton", Age = 27 });
                    return children;
                case 2:
                    children.Add(new ChildName { FirstName = "Dr", MiddleName = "Who", LastName = "Rogers", Age = 1200 });
                    children.Add(new ChildName { FirstName = "Amy", MiddleName = "Pond", LastName = "Rogers", Age = 24 });
                    children.Add(new ChildName { FirstName = "Impossible", MiddleName = "Girl", LastName = "Rogers", Age = 30 });
                    return children;
                default:
                    return children;
            }
        }
    }
}
