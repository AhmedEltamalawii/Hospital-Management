using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    class HospitalManagementSystem
    {
        private Patient head;
        private int nextId = 1;

        private void ClearScreen()
        {
            Console.Clear();
        }

        private void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private void DisplayPatientHeader()
        {
            Console.WriteLine("\n" + new string('-', 80));
            Console.WriteLine("{0,-5}{1,-20}{2,-10}{3,-20}{4,-25}", "ID", "Name", "Age", "Contact", "Medical History");
            Console.WriteLine(new string('-', 80));
        }

        private void DisplayPatientRow(Patient p)
        {
            Console.WriteLine("{0,-5}{1,-20}{2,-10}{3,-20}{4,-25}",
                p.Id, p.Name, p.Age, p.Contact, p.MedicalHistory);
        }

        public HospitalManagementSystem()
        {
            head = null;
        }

        public void AddPatient()
        {
            ClearScreen();
            Console.WriteLine("=== ADD NEW PATIENT ===\n");

            Patient newPatient = new Patient();
            newPatient.Id = nextId++;

            Console.Write("Enter patient name: ");
            newPatient.Name = Console.ReadLine();

            Console.Write("Enter patient age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number for age: ");
            }
            newPatient.Age = age;

            Console.Write("Enter contact number: ");
            newPatient.Contact = Console.ReadLine();

            Console.Write("Enter medical history: ");
            newPatient.MedicalHistory = Console.ReadLine();

            newPatient.Next = null;

            if (head == null)
            {
                head = newPatient;
            }
            else
            {
                Patient temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newPatient;
            }

            Console.WriteLine("\nPatient added successfully with ID: " + newPatient.Id);
            PressAnyKey();
        }

        public void SearchPatient()
        {
            ClearScreen();
            Console.WriteLine("=== SEARCH PATIENT ===\n");

            if (head == null)
            {
                Console.WriteLine("No patients in the system.");
                PressAnyKey();
                return;
            }

            Console.WriteLine("Search by:\n");
            Console.WriteLine("1. Patient ID");
            Console.WriteLine("2. Name");
            Console.Write("Enter your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.Write("Invalid choice. Please enter 1 or 2: ");
            }

            bool found = false;

            if (choice == 1)
            {
                Console.Write("Enter patient ID: ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("Invalid input. Please enter a number for ID: ");
                }

                Patient temp = head;
                while (temp != null)
                {
                    if (temp.Id == id)
                    {
                        DisplayPatientHeader();
                        DisplayPatientRow(temp);
                        found = true;
                        break;
                    }
                    temp = temp.Next;
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter patient name: ");
                string name = Console.ReadLine();

                Patient temp = head;
                DisplayPatientHeader();
                while (temp != null)
                {
                    if (temp.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                    {
                        DisplayPatientRow(temp);
                        found = true;
                    }
                    temp = temp.Next;
                }
            }

            if (!found)
            {
                Console.WriteLine("No matching patients found.");
            }

            PressAnyKey();
        }

        public void DeletePatient()
        {
            ClearScreen();
            Console.WriteLine("=== DELETE PATIENT ===\n");

            if (head == null)
            {
                Console.WriteLine("No patients in the system.");
                PressAnyKey();
                return;
            }

            DisplayAllPatients();

            Console.Write("\nEnter patient ID to delete: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Invalid input. Please enter a number for ID: ");
            }

            Patient current = head;
            Patient previous = null;

            while (current != null)
            {
                if (current.Id == id)
                {
                    if (previous == null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    Console.WriteLine("\nPatient deleted successfully.");
                    PressAnyKey();
                    return;
                }
                previous = current;
                current = current.Next;
            }

            Console.WriteLine("\nPatient not found.");
            PressAnyKey();
        }

        public void DisplayAllPatients()
        {
            ClearScreen();
            Console.WriteLine("=== ALL PATIENTS ===\n");

            if (head == null)
            {
                Console.WriteLine("No patients in the system.");
                return;
            }

            DisplayPatientHeader();

            Patient temp = head;
            while (temp != null)
            {
                DisplayPatientRow(temp);
                temp = temp.Next;
            }
        }


        
        //public void MainMenu()
        //{
        //    while (true)
        //    {
        //        ClearScreen();
        //        Console.WriteLine("====> HOSPITAL MANAGEMENT SYSTEM BY Ahmed Sherif <====\n");
        //        Console.WriteLine("1. Add New Patient");
        //        Console.WriteLine("2. Search Patient");
        //        Console.WriteLine("3. Delete Patient");
        //        Console.WriteLine("4. View All Patients");
        //        Console.WriteLine("5. Exit");
        //        Console.Write("\nEnter your choice To make operation: ");

        //        int choice;
        //        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
        //        {
        //            Console.Write("Invalid choice. Please enter a number between 1 and 5: ");
        //        }

        //        switch (choice)
        //        {
        //            case 1:
        //                AddPatient();
        //                break;
        //            case 2:
        //                SearchPatient();
        //                break;
        //            case 3:
        //                DeletePatient();
        //                break;
        //            case 4:
        //                DisplayAllPatients();
        //                PressAnyKey();
        //                break;
        //            case 5:
        //                Console.WriteLine("\nExiting system. Goodbye!");
                          
        //                return;
        //        }
        //    }
        //}

    }
}
