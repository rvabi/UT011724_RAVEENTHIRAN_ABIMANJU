using Banking_Application;
using System.Security.Principal;
using System.Transactions;




Account acc = new Account();
List<string> transactions = new List<string>();


ShowWelcomeMessage();

bool option = true;

while (option)
{


ShowMenu();
Console.Write("Choose an option: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    

    switch (choice)
{
    case 1:

        Console.Clear();

        Console.WriteLine("Creating an Account...");

        Console.WriteLine("Enter Your Name :");
        string AccontHolderName = Console.ReadLine();
        acc.AccountHolderName = AccontHolderName;


        Console.WriteLine("Enter Your Account Number :");
        int AccountNumber = Convert.ToInt32(Console.ReadLine());
        acc.AccountNumber = AccountNumber;

        Console.WriteLine("Enter the Opening Balance :");
        decimal AccountBalance = Math.Round(Convert.ToDecimal(Console.ReadLine()), 2);
        acc.AccountBalance = AccountBalance;

        Console.WriteLine("Account Created Successfully!");

        break;

    case 2:

        Console.Clear();

        ShowAccountDetails(acc);

        break;

    case 3:
            Console.Clear();
            Console.WriteLine("Checking Balance...");
            

            Console.WriteLine($"Current Balance : {acc.AccountBalance:F2}");

            break;

    case 4:
        Console.Clear();
        Console.WriteLine("Depositing Money...");
            
        Console.Write("Enter Deposit Amount : ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        acc.Deposit(deposit);
        transactions.Add($"Deposited :{deposit:F2}");
        break;

    case 5:
        Console.WriteLine("Withdrawing Money...");
        Console.Clear();

        Console.Write("Enter Withdraw Amount : ");
        decimal withdraw = Convert.ToDecimal(Console.ReadLine());

        acc.Withdraw(withdraw);
        transactions.Add($"Withdrawn :{withdraw:F2}");
        break;

    case 6:

            Console.Clear();
            Console.WriteLine("===== TRANSACTION HISTORY =====");

            if (transactions.Count == 0)
            {
                Console.WriteLine("No Transactions Found!");
            }
            else
            {
                foreach (string transaction in transactions)
                {
                    Console.WriteLine(transaction);
                }
            }

        break;


    case 7:
        Console.WriteLine("Thank you for using RV TIC BANK.");
        option = false;
        break;
        
    default:
        Console.WriteLine("Invalid Option!");
        break;
    }
    
    if (option)
    {
        Console.WriteLine("press any kay .....");
        Console.ReadKey();
        Console.Clear();
    }

}
static void ShowWelcomeMessage()
{
    Console.WriteLine("==========================================");
    Console.WriteLine("==             RV TIC BANK              ==");
    Console.WriteLine("==--------------------------------------==");
    Console.WriteLine("==     Welcome to the Banking System    ==");
    Console.WriteLine("==========================================");
}

static void ShowMenu()
{
    Console.WriteLine("\n========= MENU =========");
    Console.WriteLine("1.Account Creation");
    Console.WriteLine("2.View Account");
    Console.WriteLine("3.Check Balance");
    Console.WriteLine("4.Deposit");
    Console.WriteLine("5.Withdraw");
    Console.WriteLine("6.Transaction History");
    Console.WriteLine("7.Exit");
}

static void ShowAccountDetails(Account acc)
{
    Console.WriteLine("Viewing Account Details...");

    Console.WriteLine("========= ACCOUNT DETAILS =========");
    Console.WriteLine("Bank Name          : " + acc.BankName);
    Console.WriteLine("Account Holder Name: " + acc.AccountHolderName);
    Console.WriteLine("Account Number     : " + acc.AccountNumber);
    Console.WriteLine("Current Balance    : " + acc.AccountBalance);
}







