namespace Ploj; //A Simple ATM
class Program
{
    public class CardHolder
    {
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public String getNum()
        {
            return cardNum;
        }
        public int getPin()
        {
            return pin;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public String getLasttName()
        {
            return lastName;
        }
        public double getBalance()
        {
            return balance;
        }
        public void setNum(string newCardNum)
        {
            cardNum = newCardNum;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }
        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

        static void Main(string[] args)  //Project 2 ATM
        {
            void printOptions()
            {
                Console.WriteLine("Choose one option");
                Console.WriteLine("[1] Deposit");
                Console.WriteLine("[2] Withdraw");
                Console.WriteLine("[3] Show Balance");
                Console.WriteLine("[4] Exit");
            }
            void deposit(CardHolder currentUser)
            {
                Console.WriteLine("How much would you like to deposit?");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposit);
                Console.WriteLine("Thank you for the deposit. The balance is: " + currentUser.getBalance());
            }
            void withdraw(CardHolder currentUser)
            {
                Console.WriteLine("How much would you like to withdraw?");
                double withdrawl = Double.Parse(Console.ReadLine());
                if (currentUser.getBalance() < withdrawl)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawl);
                    Console.WriteLine("Thank you for the withdrawl");
                }
            }
            void balance(CardHolder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.getBalance());
            }

            List<CardHolder> cardHolders = new List<CardHolder>();
            cardHolders.Add(new CardHolder("1534864886", 9415, "Jhon", "Smith", 1560.54));
            cardHolders.Add(new CardHolder("9451376545", 6521, "Kelly", "Klarksson", 745.23));
            cardHolders.Add(new CardHolder("8124359712", 3248, "Anders", "Wilks", 56.52));
            cardHolders.Add(new CardHolder("1534864885", 6548, "Emmy", "Grants", 4584.45));
            cardHolders.Add(new CardHolder("5312794869", 1984, "Olof", "Anderssen", 150.89));

            Console.WriteLine("SimpleATM");
            Console.WriteLine("Insert card numer: ");
            string debitCardNum = "";
            CardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Invalid card"); }
                }
                catch
                {
                    Console.WriteLine("Invalid card");
                }
            }

            Console.WriteLine("Enter pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("Invalid pin"); }
                }
                catch
                {
                    Console.WriteLine("Invalid pin");
                }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLasttName());
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { deposit(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
            while (option != 4);
            Console.WriteLine("Exiting SimpleATM");

        }

    }

}
