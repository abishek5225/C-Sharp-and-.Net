using System;
using System.Collections.Generic;

namespace ContactManager{

    class Program{
        static List<Contact> contacts = new List<Contact>();

        static void Main(){
            bool exit = false;

            while(!exit){
                Console.WriteLine("\n----Contact Manager----");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View All Contacts");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");

                switch(Console.ReadLine()){
                    case "1":
                    AddContact();
                    break;

                    case "2":
                    ViewContacts();
                    break;

                    case "3":
                    SearchContact();
                    break;

                    case "4":
                    DeleteContact();
                    break;

                    case "5":
                    exit = true;
                    Console.WriteLine("Exiting.....");
                    break;

                    default:
                    Console.WriteLine("Invalid choice! please enter valid number to excess the services.. Thank you");
                    break;

                }
            }
        }

        static void AddContact(){
            Console.WriteLine("Enter Name: ");
            string name= Console.ReadLine();

            Console.WriteLine("Enter Number: ");
            string number = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
        }
    }
}