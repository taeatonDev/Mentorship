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
            //Return a new list and implement the children in the list consructor. Example below in case 3. This will only fill the memory when it is returning something.
                //RESPONSE
                //I like that a LOT better.  It's less ugly.  I also didn't consider the potential memory issues doing it the way I did.  I wanted to do this the better way
                //but my brain sputtered out on me and I couldn't think how to do it because it was a list so I went with what I knew.
            List<ChildName> children = new List<ChildName>();
            switch(id)
            {
                case 1:
                    children.Add(new ChildName { FirstName = "Billy", MiddleName = "Edgar", LastName = "Eaton", Age = 12 });
                    children.Add(new ChildName { FirstName = "Gina", MiddleName = "Ray", LastName = "Eaton", Age = 4 });
                    children.Add(new ChildName { FirstName = "Ralph", MiddleName = "Wiggum", LastName = "Eaton", Age = 27 });
                    return children;
                case 2:
                    //nice
                    children.Add(new ChildName { FirstName = "Dr", MiddleName = "Who", LastName = "Rogers", Age = 1200 });
                    children.Add(new ChildName { FirstName = "Amy", MiddleName = "Pond", LastName = "Rogers", Age = 24 });
                    children.Add(new ChildName { FirstName = "Impossible", MiddleName = "Girl", LastName = "Rogers", Age = 30 });
                    return children;
                case 3:
                    return new List<ChildName>
                    {
                        new ChildName
                        {
                            FirstName = "Dr", 
                            MiddleName = "Who", 
                            LastName = "Rogers", 
                            Age = 1200
                        },
                        new ChildName
                        {
                            FirstName = "Amy", 
                            MiddleName = "Pond", 
                            LastName = "Rogers", 
                            Age = 24
                        }
                    };
                default:
                    // try to throw a custom exception here instead and handle it in your contract provder.
                    return children;
            }
        }
    }
}
