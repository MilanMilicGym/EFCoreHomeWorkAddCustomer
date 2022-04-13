using System;
using EFCoreHomeWorkAddCustomer.Entities;

namespace EFCoreHomeWorkAddCustomer
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            Console.WriteLine("Bye!");

        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Us first menu");
            Console.WriteLine();
            Console.WriteLine("Options : ");
            Console.WriteLine("1) Add Employee : ");
            Console.WriteLine("2) Add Customer : ");

            Console.WriteLine("0) exit the application");

            Console.WriteLine();
            Console.WriteLine("Enter the option number : ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddEmployee();
                    HitAndKey();
                    
                    return true;
                case "2":
                    AddCustomer();
                    HitAndKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }







        }
        private static void HitAndKey()
        {
            Console.WriteLine("Hit any key to continue...");
            Console.ReadLine();
        }
        private static void AddEmployee()
        {
            Console.Clear();
            Console.WriteLine("Adding new employee... ");

            using (var db = new NorthwindContext())
            {
                Console.WriteLine("Enter First name : ");
                var employeeFirstName = Console.ReadLine();

                Console.WriteLine("Enter Last name : ");
                var employeeLastName = Console.ReadLine();

                Console.WriteLine("Enter title: ");
                    var employeeTitle = Console.ReadLine();

                Console.WriteLine("Enter TitleOfCourtesy: ");
                    var employeeTitleOfCourtesy = Console.ReadLine();

                Console.WriteLine("Enter City: ");
                    var employeeCity = Console.ReadLine();

                Console.WriteLine("Enter Country: ");
                var employeeCountry = Console.ReadLine();

                var newEmployee = new Employee();

                newEmployee.FirstName = employeeFirstName;

                newEmployee.LastName = employeeLastName;
               

                newEmployee.Title = employeeTitle;
                

                newEmployee.TitleOfCourtesy = employeeTitleOfCourtesy;
                

                newEmployee.City= employeeCity;
                

                newEmployee.Country = employeeCountry;

                db.Employees.Add(newEmployee);



                db.SaveChanges();
                Console.WriteLine("Employee created with ID" + newEmployee.EmployeeId);
            }




        }
        private static void AddCustomer()
        {
            Console.Clear();
            Console.WriteLine("Adding new Customer...");
            using (var db = new NorthwindContext())
            {
            
                Console.WriteLine(" Enter Company name: ");
                var customerCompanyName = Console.ReadLine();

                Console.WriteLine(" Enter Contact name: ");
                var customerContactName = Console.ReadLine();

                Console.WriteLine(" Enter Contact title: ");
                var customerContactTitle = Console.ReadLine();

                Console.WriteLine(" Enter Address: ");
                var customerAddress = Console.ReadLine();

                Console.WriteLine(" Enter City: ");
                var customerCity = Console.ReadLine();

                Console.WriteLine(" Enter Coountry: ");
                var customerCountry = Console.ReadLine();

              

                var newCustomer = new Customer();
                newCustomer.CompanyName= customerCompanyName;
                newCustomer.ContactName= customerContactName;
                newCustomer.ContactTitle= customerContactTitle;
                newCustomer.Address= customerAddress;
                newCustomer.City= customerCity;
                newCustomer.Country= customerCountry;
                newCustomer.CustomerId = Console.ReadLine();


               db.Customers.Add(newCustomer);
                db.SaveChanges();
             

    } 
        }
    } }
