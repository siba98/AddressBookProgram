using System;

namespace AddressBook2
{
    public class AddressBookSystem
    {
        /// <summary>
        /// UC1 ==> added contact details
        /// </summary>
        private void ContactDetails()
        {
            //Created object of Contacts class
            Contacts person = new Contacts();

            Console.WriteLine("***Enter the Person Details***");

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

            Console.WriteLine("*****************\n");
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
        /// Choose options for adding the details in a address book
        /// </summary>
        public void ChooseOption()
        {
            Console.WriteLine("\n****************\nPlease Choose Any Option And Add The Details\n****************\n");
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("Choose a number: " + "\n1 :Create Contact\n" + "2 :Exit From the Address Book\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        ContactDetails();
                        break;
                    case 2:
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