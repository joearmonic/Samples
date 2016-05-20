using System;
using System.Collections.Generic;
using System.IO;
using FraudPrevention.DomainModel;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Console.WriteLine("Fraud prevention system started");
        // N.B: Next sequence tries to emulate a complete order stream that maybe comes completed
        // TODO: Create the stream previously.
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        {
            int recordsCount = -1;
            List<Order> orders = new List<Order>();

            try
            {
                while (!sr.EndOfStream)
                {
                    // First time we need the number of records:
                    if (recordsCount == -1)
                    {
                        var numberOfRecordsInput = sr.ReadLine();
                        if (!int.TryParse(numberOfRecordsInput, out recordsCount))
                        {
                            // No number in this steps means an error
                            throw new InvalidCastException("The entry is non a number. Invalid stream!");
                        }
                    }
                    else
                    {
                        // TODO: time to read orders and validate.
                        // Because I have not enough time I can't explain show my architecture:
                        // Its based on instantiate as orders as lines I found in the stream
                        // and parse those orders using as Validator implementations I have 
                        // by injecting them with Validator factory.
                        // To be fast enough I will user TPL to validate orders in differente theads
                        // and wait for its outcomes.
                        // Then I will order the fraudulent orders removed those that are equal just in case
                        // implementing using IEqualityComparer.
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
