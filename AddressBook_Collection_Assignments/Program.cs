using System;

namespace AddressBook2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object
            AddressBookSystem addressBook = new AddressBookSystem();

            Console.WriteLine("\n***********************************\nWELCOME TO ADDRESS BOOK PROGRAM\n***********************************\n\n");
            addressBook.ChooseOption();
        }
    }
}