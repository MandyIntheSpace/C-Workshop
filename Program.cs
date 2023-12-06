namespace Workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car car = new Car("Toyota", 123, 1200000);
            // Console.WriteLine(car.toString());

            BankAccount bankAccount = new BankAccount("12345678");
            bankAccount.Deposite(1000);
            bankAccount.Withdraw(500);
            Console.WriteLine(bankAccount.getBalance());
        }
    }
}