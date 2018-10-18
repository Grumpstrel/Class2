using System;

namespace CarRentalApp
{
    class Program
    {
        private static string option;

        static void Main(string[] args)
        {
            while (true)
            {
                PrintMainBanner();
                PrintMainMenu();

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        
                        PrintAccountCreationMenu();

                        Console.WriteLine("Enter first name:");
                        var firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        var lastName = Console.ReadLine();
                        var fullName = firstName + " " + lastName;

                        Console.WriteLine("Enter Address:");
                        var customerAddress = Console.ReadLine();

                        Console.WriteLine("Enter Phone Number:");
                        var customerPhoneNumber = Console.ReadLine();

                        Console.WriteLine("Enter Email Address: ");
                        var customerEmailAddress = Console.ReadLine();

                        Console.WriteLine("Enter your drivers License number:");
                        var customerDriversLicenseNumber = Console.ReadLine();

                        Console.WriteLine("Enter your rental credit card:");
                        var customerCreditCardNumber = Console.ReadLine();

                        //CreateAccount(string customerName, string customerAddress, string customerPhoneNumber, string customerEmailAddress, string driverLicenseNumber, int customerCreditCardNumber
                        var account = CustomerAccounts.CreateAccount(fullName, customerAddress, customerPhoneNumber, customerEmailAddress, customerEmailAddress, customerCreditCardNumber);

                        break;

                    case "2":

                        PrintAccountMenuHeader();
                        PrintAccountMenu();
                        Console.ReadLine();
                        break;

                    case "3":

                        PrintAllAccountsMenu();
                        PrintAllAccounts();

                        Console.ReadLine();
                        break;

                    case "4":
                        return;
                }
            }
        }

        private static void PrintMainBanner()
        {
            Console.Clear();
            PrintBannerBar();
            Console.WriteLine("1980's Enterprise Car Rental");
            PrintBannerBar();
        }

        private static void PrintAccountMenu()
        {
            Console.WriteLine("1:  Basic Info");
            //CustomerAccounts.EditAccount
            //Remember to include the insurance part

            Console.WriteLine("2:  Reserve a Car");
            //RentalAgreement.Reservation

            Console.WriteLine("3:  Picking up");
            //RentalAgreement.CheckOutVehical
            //Need to have a check to make sure that this is completed
            //InsuranceInformation.PolicyInformation

            Console.WriteLine("4:  Dropping off");
            //RentalAgreement.CheckInVehicle

            Console.WriteLine("5:  Return to MainMenu");
        }

        private static void PrintAccountMenuHeader()
        {
            Console.Clear();
            PrintBannerBar();
            Console.WriteLine($"Welcome back       this is your account menu");  //Want to add the {CustomerAccounts.GetAllAccounts.CustomerName) to the string
            PrintBannerBar();
        }

        private static void PrintMainMenu()
        {
            Console.WriteLine("1:  Create new account");
            Console.WriteLine("2:  Log into  current account");
            Console.WriteLine("3:  Print all accounts");
            Console.WriteLine("4:  Exit");
            Console.WriteLine("Select an option.");
            PrintBannerBar();
        }

        private static void PrintAccountCreationMenu()
        {
            Console.Clear();
            PrintBannerBar();
            Console.WriteLine("Account Creation Menu");
            PrintBannerBar();
        }

        private static void PrintAllAccountsMenu()
        {
            Console.Clear();
            PrintBannerBar();
            Console.WriteLine("Printing all accounts...");
            PrintBannerBar();
        }

        private static void PrintBannerBar()
        {
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine();
        }

        
        public static void PrintAllAccounts()
        {
            var accounts = CustomerAccounts.GetAllAccounts();
            foreach (var getaccount in accounts)
            {

                Console.WriteLine($"Account Number: {getaccount.CustomerAccountNumber},");
                Console.WriteLine($"Name:           {getaccount.CustomerName},");
                Console.WriteLine($"Address:        {getaccount.CustomerAddress},");
                Console.WriteLine($"Phone Number:   {getaccount.CustomerPhoneNumber},");
                Console.WriteLine($"Email:          {getaccount.CustomerEmailAddress},");
                Console.WriteLine($"Credit Card:    {getaccount.CustomerCreditCardNumber}");
                Console.WriteLine();
            }
        }
    }
}
