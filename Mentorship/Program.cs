using System;
using System.Collections.Generic;

namespace Mentorship
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //using Console.WriteLine and Console.ReadLine
            //print 3 functions
            //the user should be able to select the function desired and have it fire.
            //function 1 will be to show all the contact details for a single contact by having the user enterin the contact id.
            //function 2 will list off all the contact details for each contact available.
            //function 3 will let the user search for a parent and list the contact info for that parent.
            //the middleware is almost done and is setup to allow for the above requested.
            //the backend is almost done, just a few repositories to fill in.
            //This page is completely blank and needs to be populated.
            //I used some of the things we discussed during our mentor meeting on 1/10
            //This is due at the next mentor meeting, or at the very least you should have worked on it and be able to discuss it.
            //The target framework is 4.0 so you should be able to load it. If not let me know and I'll see what I can do.

            Console.WriteLine("Which function would you like to perform?");
            Console.WriteLine("1. View details for a single contact.");
            Console.WriteLine("2. View details for ALL contacts.");
            Console.WriteLine("3. Search for a parent and see contact details.");

            var selection = Console.ReadLine();
            try
            {
                switch (Convert.ToInt16(selection))
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter an ID:");
                            var id = Console.ReadLine();
                            if (id == "")
                            {
                                Console.WriteLine("Oops!  You did not enter an ID.  Please try again.");
                                Main(args);
                            }
                            ShowContactDetails(Convert.ToInt16(id));
                        }
                        break;
                    case 2:
                        {
                            throw new NotImplementedException();
                        }
                    case 3:
                        {
                            throw new NotImplementedException();
                        }
                    default:
                        {
                            Console.WriteLine("Oops!  You choose an invalid selection.  Please try again.");
                            Main(args);
                        }
                        break;
                };
            }
            catch (Exception)
            {

                throw;
            }
 

            

        }

        public static void ShowContactDetails(int id)
        {
            //Here are a few ways to improve this and take advantage of the Dependency Injection.
            //First taking advantage of the Dependency Injection
            //The earlier in the program you can call the configure on the injector the better.
            //Here you have a class that you are newing up. BOO. What happends when the other two functions are creaated?
            //We don't want to new up 3 instances of that class, we want to share a single instance.
            //Flip over to the Fake DI Configureation class.

            //Welcome back. I like code, I just like less of it when possible. 
            //Below you are declaring your variable with a concrete type and in the same line assigning it to a concrete type.
            //You can save time and space by using the the code item of 'var'. This changes the variable to a non-concrete type
            //until you assign an object to it. It will also help with confusion if you name it what it is. For Example:
            //var contactProvider = FakeDiProvider.GetContactProvider();
            Mentorship.MiddleWare.ContactProvider contactID = new Mentorship.MiddleWare.ContactProvider();

            //You can also apply the var here as well. The returned object from GetCOntact will define the object type of contact.
            Mentorship.Backend.Models.Contact contact = contactID.GetContact(id);

            //This is another standards item. Welcome to the world of string.Format.
            //Here is an example var x = string.Format("Hello my name is {0}. I like to climb on {1}. Can I have a {3}", object.Name, object.TreeType, object.FoodType);
            Console.WriteLine("Parent1: " + contact.Parent1.FirstName + " " + contact.Parent1.MiddleName + " " + contact.Parent1.LastName);
            Console.WriteLine("Parent2: " + contact.Parent2.FirstName + " " + contact.Parent2.MiddleName + " " + contact.Parent2.LastName);


            Console.WriteLine(contact.PropAddress.StreetAddress1);

            //More cool stuff to make this prettier.
            //if(string.IsNullorWhiteSpace(contact.PropAddress.StreetAddress2)){positive result}
            //another way that is even less code
            //string.IsNullorWhiteSpace(contact.PropAddress.StreetAddress2) ? Console.WriteLine(positiveResult) : Console.Writeline(negativResult);
            if (contact.PropAddress.StreetAddress2 != "") { Console.WriteLine(contact.PropAddress.StreetAddress2); };

            //You can apply the string.Format here again and clean it up a bit.
            Console.WriteLine(contact.PropAddress.City + ", " + contact.PropAddress.State + "  " + contact.PropAddress.ZipCode);
            Console.ReadLine();

            //Head over to AddressRepo
        }
    }
}

