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
            Mentorship.MiddleWare.ContactProvider contactID = new Mentorship.MiddleWare.ContactProvider();
            Mentorship.Backend.Models.Contact contact = contactID.GetContact(id);

            Console.WriteLine("Parent1: " + contact.Parent1.FirstName + " " + contact.Parent1.MiddleName + " " + contact.Parent1.LastName);
            Console.WriteLine("Parent2: " + contact.Parent2.FirstName + " " + contact.Parent2.MiddleName + " " + contact.Parent2.LastName);


            Console.WriteLine(contact.PropAddress.StreetAddress1);
            if (contact.PropAddress.StreetAddress2 != "") { Console.WriteLine(contact.PropAddress.StreetAddress2); };
            Console.WriteLine(contact.PropAddress.City + ", " + contact.PropAddress.State + "  " + contact.PropAddress.ZipCode);
            Console.ReadLine();
        }
    }
}

