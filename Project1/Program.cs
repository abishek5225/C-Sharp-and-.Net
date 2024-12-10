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

            contacts.Add(new Contact{
                ID = contacts.Count + 1, //This ensures that each contact gets a unique, sequential ID
                Name = name,
                Number = number,
                Email = email
            });

            Console.WriteLine("Contact added successfully!");
        }
        static void ViewContacts(){
            if(contacts.Count == 0){
                Console.WriteLine("No contacts available");
            }else{
                Console.WriteLine("\nContacts:");
                foreach(var contact in contacts){
                    Console.WriteLine($"{contact.ID}. {contact.Name} - {contact.Number} - {contact.Email}");
                }
            }
        }
        static void SearchContact(){
            Console.WriteLine("Enter name to search: ");
            string query = Console.ReadLine().ToLower();

            var results =  contacts.FindAll(c =>
            c.Name.ToLower().Contains(query) || c.Number.Contains(query)
            );

            if (results.Count > 0)
            {
                foreach (var contact in results)
                {
                    Console.WriteLine($"{contact.ID}. {contact.Name} - {contact.Number} - {contact.Email}");
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }
        static void DeleteContact(){
            Console.WriteLine("Enter ID of contact to delete: ");
            if(int.TryParse(Console.ReadLine(), out int id)){
                var contact = contacts.Find(c => c.ID == id);
                if(contact != null){
                    contacts.Remove(contact);
                    Console.WriteLine("Contact deleted successfully!");
                }else{
                    Console.WriteLine("Contact not found");
                }
            }else{
                Console.WriteLine("Invalid ID");
            }
        }
    }
    class Contact{
        public int ID{get; set;}
        public string Name { get; set; } = string.Empty; // Default value
        public string Number { get; set; } = string.Empty; // Fixed typo in property name
        public string Email { get; set; } = string.Empty; // Default value
    }
}