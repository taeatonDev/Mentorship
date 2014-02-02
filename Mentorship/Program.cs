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

                            //Before
                            //var contact = contacts.Where(c => c.Parent1.FirstName.ToLower() == searchName.ToLower() || c.Parent2.FirstName.ToLower() == searchName.ToLower());

                            //After 
                            //implementing String Compare. Research and Explain why doing it this way is better.
                                //RESPONSE
                                //This code is MUCH cleaner looking for starters.  It's readily apparently in plain English what is going on with it.  
                                //Also, you can use StringComparison.InvariantCultureIgnoreCase and it will return the correct answer no matter what language you are looking at.
                                //It's better on the resource usage side because .ToLower creates additional strings in memory to do the operation.  On a small scale like this, not so bad.  
                                //On a much larger scale, exponentially worse.  Doing this with string.equals even in the small scale creates a standard and also helps to reinforce the 
                                //idea that this is a better way of doing things.

                            //Did you ever step through this and compare how it functions as appose to a List or Enum? 
                            //Also go research Hashset and try to apply it here and see what it does. http://stackoverflow.com/questions/4558754/define-what-is-a-hashset
                                //RESPONSE
                                //I didn't step through it to look at the differences.  I know that this method doesn't have much of a resource footprint until you decide to use the variable.
                                //List and Enum are completely in memory already by the time you'd try to do something like this on them.  Is that what you were trying to get at?
                                //Hashset looks really interesting.  It's apparently about the fastest way available to do something like this.  I'll look at how to go about implementing it
                                //and update later.  Wanted to get my own comments back to you before then.
                            var contact = contacts.Where(c => 
                                String.Equals(c.Parent1.FirstName, searchName, StringComparison.CurrentCultureIgnoreCase) || 
                                String.Equals(c.Parent2.FirstName, searchName, StringComparison.CurrentCultureIgnoreCase));

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
                //Because this is happening in the Main method which in this instance is the top level method, 
                //having the catch just throw doesn't accomplish anything. What is it throwing it too? If we were to say... write the 
                //exception to a Log using Log4Net or NLog and then handle the exception, then this would make since. 
                //Hint Hint. Look into NLog and Log4Net, we will be implementing them in the next project. Both are top loggers in the industry right now. I prefer Log4Net.
                    //RESPONSE
                    //I did this here really because it's habit.  Kind of my own standard, bad or good.  I think I intended to throw a message box so I'd know exactly what the error was,
                    //but I obviously didn't so it's here really for debug purposes.  I will look into the loggers you mentioned.
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

            //Did you know that Console.WriteLine functions as string.Format()? I didn't. ReSharper caught this one. Kind of cool.
                //RESPONSE
                //I did not know that.  Is this how it was written when you looked this over or did you modify?  Cool and quite convenient.
                //If it was like this when you were looking at it, I had no idea I even did that.  Happy accident I guess.
                //I wonder if putting string.Format in the WriteLine causes it to run that code twice?
            Console.WriteLine("{0}, {1}  {2}", contact.PropAddress.City, contact.PropAddress.State, contact.PropAddress.ZipCode);

            Console.WriteLine(string.Format("Children"));
            foreach (var child in contact.Children)
            {
                Console.WriteLine(string.Format("     {0} {1} {2}, Age: {3}", child.FirstName, child.MiddleName, child.LastName, child.Age));
            }



        }
    }
}

