using System;
using System.Collections.Generic;
using System.IO;
using FraudPrevention.DomainModel;

internal class Solution
{
    private static void Main(String[] args)
    {
        Console.WriteLine("Fraud prevention system started");
        using (StreamReader sw = new StreamReader("SampleInput.txt"))
        {
            Console.SetIn(sw);
            int recordsCount = -1;
            List<Order> orders = new List<Order>();

            try
            {
                while (!sw.EndOfStream)
                {
                    // First time we need the number of records:
                    if (recordsCount == -1)
                    {
                        var numberOfRecordsInput = sw.ReadLine();
                        if (!int.TryParse(numberOfRecordsInput, out recordsCount))
                        {
                            // No number in this steps means an error
                            throw new InvalidCastException("The entry is non a number. Invalid stream!");
                        }
                    }
                    else
                    {
                        string lineRecord = sw.ReadLine();
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
            finally
            {
                sw.Close();
            }
        }
    }
}