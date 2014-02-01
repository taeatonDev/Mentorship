using System;
using System.Collections.Generic;
using Mentorship;
using System.Linq;

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

            FakeDiConfiguration.Configure();

            Console.WriteLine("Which function would you like to perform?");
            Console.WriteLine("1. View details for a single contact.");
            Console.WriteLine("2. View details for ALL contacts.");
            Console.WriteLine("3. Search for a parent and see contact details.");

            var selection = Console.ReadLine();
            try
            {
                var contactProvider = MiddleWare.ContactProvider.GetContractProvider();
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

                            var contact = contactProvider.GetContact(Convert.ToInt16(id));

                            ShowContactDetails(contact);
                            Console.ReadLine();

                        }
                        break;
                    case 2:
                        {
                            var contacts = contactProvider.GetAllContacts();
                            foreach (var contact in contacts)
                            {
                                ShowContactDetails(contact);
                            }
                            Console.ReadLine();

                            break;
                        }
                    case 3:
                        {
                            var contacts = contactProvider.GetQueryableContacts();
                            Console.WriteLine("Please enter a first name to search for:");
                            var searchName = Console.ReadLine();

                            var contact = contacts.Where(c => c.Parent1.FirstName.ToLower() == searchName.ToLower() || c.Parent2.FirstName.ToLower() == searchName.ToLower());

                            foreach (var con in contact)
                            {
                                ShowContactDetails(con);
                            }
                            Console.ReadLine();
                            break;
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

        public static void ShowContactDetails(Backend.Models.Contact contact)
        {

            Console.WriteLine(string.Format("Parent1: {0} {1} {2}", contact.Parent1.FirstName, contact.Parent1.MiddleName, contact.Parent1.LastName));
            Console.WriteLine(string.Format("Parent2: {0} {1} {2}", contact.Parent2.FirstName, contact.Parent2.MiddleName, contact.Parent2.LastName));
            Console.WriteLine(contact.PropAddress.StreetAddress1);
            if (!String.IsNullOrWhiteSpace(contact.PropAddress.StreetAddress2)) { Console.WriteLine(contact.PropAddress.StreetAddress2); };
            Console.WriteLine(string.Format("{0}, {1}  {2}", contact.PropAddress.City, contact.PropAddress.State, contact.PropAddress.ZipCode));

            Console.WriteLine(string.Format("Children"));
            foreach (var child in contact.Children)
            {
                Console.WriteLine(string.Format("     {0} {1} {2}, Age: {3}", child.FirstName, child.MiddleName, child.LastName, child.Age));
            }



        }
    }
}

