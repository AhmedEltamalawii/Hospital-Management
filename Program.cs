
namespace HospitalManagement
{ 

  class Program
  {
     static void Main(string[] args)
     {
            // this view in main made by AI
            Console.Title = "Hospital Management System by Ahmed Sherif";

            // Set console colors
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // Display fancy welcome screen
            Console.WriteLine("\n\n");
            Console.WriteLine(@"  _   _   ___   _   _ _____ ___ ___  _   _   ___   ___ ___ ___ ___ ");
            Console.WriteLine(@" | | | | / _ \ | | | |_   _|_ _/ _ \| | | | / _ \ / __| __/ __/ __|");
            Console.WriteLine(@" | |_| || (_) || |_| | | |  | | (_) | |_| || (_) | (__| _|\__ \__ \");
            Console.WriteLine(@"  \___/  \___/  \___/  |_| |___\___/ \___/  \___/ \___|___|___/___/");
            Console.WriteLine("\n");
            Console.WriteLine(new string('=', 70));
            Console.WriteLine("  WELCOME TO HOSPITAL MANAGEMENT SYSTEM - DEVELOPED BY AHMED SHERIF");
            Console.WriteLine(new string('=', 70));
            Console.WriteLine("\n");

            // Loading animation
            Console.Write("Loading system");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(300);
            }
            Console.Clear();

            HospitalManagementSystem hospital = new HospitalManagementSystem();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine(@"  __  __       _         __  __                  _   _             ");
                Console.WriteLine(@" |  \/  | __ _(_)_ __   |  \/  | ___ _ __  _ __ | |_(_)_ __   __ _ ");
                Console.WriteLine(@" | |\/| |/ _` | | '_ \  | |\/| |/ _ \ '_ \| '_ \| __| | '_ \ / _` |");
                Console.WriteLine(@" | |  | | (_| | | | | | | |  | |  __/ |_) | |_) | |_| | | | | (_| |");
                Console.WriteLine(@" |_|  |_|\__,_|_|_| |_| |_|  |_|\___| .__/| .__/ \__|_|_| |_|\__, |");
                Console.WriteLine(@"                                     |_|   |_|                |___/ ");
                Console.WriteLine("\n");
                Console.WriteLine(new string('═', 60));
                Console.WriteLine("  MAIN Action IN SYSTEM");
                Console.WriteLine(new string('═', 60));
                Console.WriteLine("\n");
                Console.WriteLine("  ┌───────────────────────────────────────────────┐");
                Console.WriteLine("  │  1. Add New Patient                            │");
                Console.WriteLine("  │  2. Search Patient                             │");
                Console.WriteLine("  │  3. Delete Patient                             │");
                Console.WriteLine("  │  4. View All Patients                          │");
                Console.WriteLine("  │  5. Exit System                                │");
                Console.WriteLine("  └───────────────────────────────────────────────┘");
                Console.WriteLine("\n");
                Console.Write("  Please enter your choice (1-5): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            hospital.AddPatient();
                            break;
                        case 2:
                            hospital.SearchPatient();
                            break;
                        case 3:
                            hospital.DeletePatient();
                            break;
                        case 4:
                            hospital.DisplayAllPatients();
                            Console.WriteLine("\nPress any key to return to main menu...");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine(@"  _____                 _ _                ");
                            Console.WriteLine(@" | ____|_   _____ _ __ | (_)_ __   ___     ");
                            Console.WriteLine(@" |  _| \ \ / / _ \ '_ \| | | '_ \ / _ \    ");
                            Console.WriteLine(@" | |___ \ V /  __/ | | | | | | | |  __/    ");
                            Console.WriteLine(@" |_____| \_/ \___|_| |_|_|_|_| |_|\___|   ");
                            Console.WriteLine("\n");
                            Console.WriteLine("  Thank you for using Hospital Management System!");
                            Console.WriteLine("  System shutting down...");
                            System.Threading.Thread.Sleep(2000);
                            return;
                        default:
                            Console.WriteLine("  Invalid choice! Please select 1-5.");
                            System.Threading.Thread.Sleep(1000);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("  Invalid input! Please enter a number.");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
  }
}

