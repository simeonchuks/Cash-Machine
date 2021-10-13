using System;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundredNote = 10;
            int fiftyNote = 10;
            int twentyNote = 10;
            int tenNote = 10;
            int fiveNote = 10;
            int oneNote = 10;

            int originalWithdrawAmount = 0;
            int calculateWithdrawAmount = 0;
            int noteCount = 0;

            while (true)
            {
                Console.Write("What Transaction will you like to Perform? R = Restock. W = Withdraws. I = Number of Notes in the Machine. Q = Quit ");
                string command = Console.ReadLine().ToLower();

                if (command.Equals("w"))
                {
                    calculateWithdrawAmount = 0;
                    Console.Write("Enter the amount you want to withdraw ");
                    int withdrawAmount = int.Parse(Console.ReadLine());
                    originalWithdrawAmount = withdrawAmount;

                    while (withdrawAmount >= 100)
                    {
                        noteCount = 100;
                        hundredNote = hundredNote - 1;
                        withdrawAmount -= noteCount;
                        calculateWithdrawAmount += noteCount;
                    }

                    while (withdrawAmount >= 50)
                    {
                        noteCount = 50;
                        fiftyNote -= 1;
                        withdrawAmount -= noteCount;
                        calculateWithdrawAmount += noteCount;
                    }

                    while (withdrawAmount >= 20)
                    {
                        noteCount = 20;
                        fiftyNote -= 1;
                        withdrawAmount -= noteCount;
                        calculateWithdrawAmount += noteCount;
                    }

                    while (withdrawAmount >= 10)
                    {
                        noteCount = 10;
                        tenNote -= 1;
                        withdrawAmount -= noteCount;
                        calculateWithdrawAmount += noteCount;
                    }

                    while (withdrawAmount >= 5)
                    {
                        noteCount = 5;
                        fiveNote -= 1;
                        withdrawAmount -= noteCount;
                        calculateWithdrawAmount += noteCount;
                    }

                    while (withdrawAmount >= 1)
                    {
                        if (withdrawAmount > oneNote)
                        {
                            break;
                        }

                        noteCount = 1;
                        oneNote -= 1;
                        withdrawAmount -= noteCount;
                        calculateWithdrawAmount += noteCount;
                    }

                    if (calculateWithdrawAmount == originalWithdrawAmount)
                    {
                        Console.WriteLine("Success: Dispensed " + calculateWithdrawAmount);
                        Console.Write("Machine Balance: \n");
                        Console.WriteLine("100 {0}", hundredNote);
                        Console.WriteLine("50 {0}", fiftyNote);
                        Console.WriteLine("20 {0}", twentyNote);
                        Console.WriteLine("10 {0}", tenNote);
                        Console.WriteLine("5 {0}", fiveNote);
                        Console.WriteLine("1 {0}", oneNote);
                    }
                    else
                    {
                        Console.WriteLine("Failure: insufficient funds");
                    }
                }

                else if (command.Equals("r"))
                {
                    
                    Console.Write("Enter the amount you want to restock ");
                    int restockAmount = 10;
                    string[] deno = { "hundredNote", "fiftyNote", "twentyNote", "tenNote", "fiveNote", "oneNote" };

                    foreach (var item in deno)
                    {
                        if (restockAmount > hundredNote || restockAmount > fiftyNote || restockAmount > twentyNote || restockAmount > tenNote
                                                        || restockAmount > fiveNote || restockAmount > oneNote)
                        {
                            hundredNote = restockAmount;
                            fiftyNote = restockAmount;
                            twentyNote = restockAmount;
                            tenNote = restockAmount;
                            fiveNote = restockAmount;
                            oneNote = restockAmount;

                            Console.Write("Machine Balance: \n");    
                            Console.WriteLine("100 {0}", hundredNote);
                            Console.WriteLine("50 {0}", fiftyNote);
                            Console.WriteLine("20 {0}", twentyNote);
                            Console.WriteLine("10 {0}", tenNote);
                            Console.WriteLine("5 {0}", fiveNote);
                            Console.WriteLine("1 {0}", oneNote);

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Restocking Failed");
                        }
                    }
                }

                else if (command.Equals("i"))
                {
                    int[] denominations = { 100, 20, 1 };
                    foreach (var item in denominations)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("100 {0}", hundredNote);
                    Console.WriteLine("20 {0}", twentyNote);
                    Console.WriteLine("1 {0}", oneNote);
                }

                else if (command.Equals("q"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Failure: Invalid Command");
                }
            }
        }
    }
}
