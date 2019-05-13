using System;
using DesafioExecoes.Entities;
using DesafioExecoes.Entities.Exceptions;

namespace DesafioExecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance , withdrawlimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
                Console.WriteLine("New balance: "+account.Balance);
            }catch(FormatException e)
            {
                Console.WriteLine("Error! "+e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
