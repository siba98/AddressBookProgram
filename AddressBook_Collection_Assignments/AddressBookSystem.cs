using System;
using System.Collections.Generic;

namespace AddressBook2
{
    public class AddressBookSystem
    {
        //declaring a List
        public List<Contacts> People = new List<Contacts>();

        /// <summary>
        /// UC1 ==> added contact details
        /// </summary>
        public void ContactDetails()
        {
            //Created object of Contacts class
            Contacts person = new Contacts();

            Console.WriteLine("******Enter the Person Details******");

            Console.Write("Enter First Name: ");
            person.firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            person.address = Console.ReadLine();

            Console.Write("Enter City name: ");
            person.city = Console.ReadLine();

            Console.Write("Enter State name: ");
            person.state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            person.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Phone Number: ");
            person.phonenumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Email ID: ");
            person.email = Console.ReadLine();

            //added the details of the person to the list
            People.Add(person);
            Console.WriteLine("Successfully Added the Person Details");
        }


        /// <summary>
        /// printing the details
        /// </summary>
        /// <param name="person"></param>
        public void PrintDetails(Contacts person)
        {
            Console.WriteLine("First Name: " + person.firstname);
            Console.WriteLine("Last Name: " + person.lastname);
            Console.WriteLine("Address: " + person.address);
            Console.WriteLine("City: " + person.city);
            Console.WriteLine("State: " + person.state);
            Console.WriteLine("Zip Code: " + person.zipcode);
            Console.WriteLine("Phone Number: " + person.phonenumber);
            Console.WriteLine("Email ID: " + person.email);
            Console.WriteLine("-------------------------------------------");
        }


        /// <summary>
        /// UC2 ==> Check any details present in list or not 
        /// </summary>
        public void ListAllContacts()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintDetails(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }


        /// <summary>
        /// UC3 ==> update the contact details which exist in the list
        /// </summary>
        public void UpdateExistingContact()
        {
            Console.WriteLine("Press 1 If you want to edit any Contact in the Address Book");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter the First Name of the Person U want to update");
                    string firstname = Console.ReadLine();
                    Contacts person = People.Find(x => x.firstname.ToLower() == firstname.ToLower());
                    if (person == null)
                    {
                        Console.WriteLine("That person U entered is not found");
                    }

                    Console.WriteLine("Are you sure you want to edit the person details from your address book? Enter --> (Y/N)");
                    PrintDetails(person);
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Press 1 if u want to edit the LastName");
                        Console.WriteLine("Press 2 if u want to edit the Address");
                        Console.WriteLine("Press 3 if u want to edit the City");
                        Console.WriteLine("Press 4 if u want to edit the State");
                        Console.WriteLine("Press 5 if u want to edit the Zip Code");
                        Console.WriteLine("Press 6 if u want to edit the Phone Number");
                        Console.WriteLine("Press 7 if u want to edit the Email Id");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter New LastName; ");
                                person.lastname = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Last Name: " + person.lastname);
                                break;
                            case 2:
                                Console.WriteLine("Enter New Address; ");
                                person.address = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Address: " + person.address);
                                break;
                            case 3:
                                Console.WriteLine("Enter New City: ");
                                person.city = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("City: " + person.city);
                                break;
                            case 4:
                                Console.WriteLine("Enter New State: ");
                                person.state = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("MobileNumber: " + person.state);
                                break;
                            case 5:
                                Console.WriteLine("Enter New ZipCode: ");
                                person.zipcode = Convert.ToInt32(Console.ReadLine());
                                People.Add(person);
                                Console.WriteLine("ZipCode: " + person.zipcode);
                                break;
                            case 6:
                                Console.WriteLine("Enter New PhoneNumber: ");
                                person.phonenumber = Convert.ToDouble(Console.ReadLine());
                                People.Add(person);
                                Console.WriteLine("PhoneNumber: " + person.phonenumber);
                                break;
                            case 7:
                                Console.WriteLine("Enter New Email ID: ");
                                person.email = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Email Id: " + person.email);
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Console.WriteLine("OKK. Press any key to continue.");
                    }
                    ListAllContacts();
                    break;
                default:
                    Console.WriteLine("Thanku!!!");
                    break;
            }
        }

        /// <summary>
        /// Choose options for adding the details in a address book
        /// </summary>
        public void ChooseOption()
        {
            Console.WriteLine("\n****************\nPlease Choose Any Option And Add The Details\n****************\n");
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("Choose a number: " + "\n1 :Create Contact\n" + "2 :List All People Present in the List\n"+ "3 :Edit Existing Contact\n" + "4 :Exit From the Address Book\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        ContactDetails();
                        break;
                    case 2:
                        ListAllContacts();
                        break;
                    case 3:
                        ListAllContacts();
                        UpdateExistingContact();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choose Valid Option!!");
                        break;
                }
            }
        }
    }
}