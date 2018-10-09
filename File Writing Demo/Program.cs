using System;
using System.Collections.Generic;
using System.IO;

namespace File_Writing_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of accounts
            var accounts = new List<Account3>
            {
                new Account3("Dopey", 500),
                new Account3("Sleepy"),
                new Account3("Sneezy", 300)
            };

            // Write these records to a file
            WriteFile(accounts);                
        }

        static void WriteFile(List<Account3> accts)
        {
            StreamWriter outputFile = File.CreateText("accounts.txt");
            string record;
            foreach (var acct in accts)
            {
                record = $"{acct.Name},{acct.Balance}";
                Console.WriteLine($"Writing record: {record}");
                outputFile.WriteLine(record);
            }
            outputFile.Close();
        }
    }
}
