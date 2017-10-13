using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                DateTime date1, date2;

                // Informs user of what program accomplishes and prompts user to enter a date in a specific format
                Console.WriteLine("This program will calculate the difference between two dates in days, hours, and minutes.");
                Console.WriteLine("Please enter a date in the format of MM/DD/YYYY:");
                string input1 = Console.ReadLine();

                // Check that first date was entered in the correct format
                while (!DateTime.TryParse(input1, out date1))
                {
                    Console.WriteLine("Date was not entered correctly. Please enter a date in the format of MM/DD/YYYY:");
                    input1 = Console.ReadLine();
                }

                // Prompt user to enter a second date in a specific format 
                Console.WriteLine("Please enter a second date in the format of MM/DD/YYYY:");
                string input2 = Console.ReadLine();

                // Check that second date was entered in the correct format
                while (!DateTime.TryParse(input2, out date2))
                {
                    Console.WriteLine("Date was not entered correctly. Please enter a second date in the format of MM/DD/YYYY:");
                    input2 = Console.ReadLine();
                }

                // Use TimeSpan to calculate difference between two dates
                TimeSpan difference = date2 - date1;
                double days = Math.Abs(difference.TotalDays);
                double hours = Math.Abs(difference.TotalHours);
                double minutes = Math.Abs(difference.TotalMinutes);

                Console.WriteLine("The difference between the dates is:\r\n{0} days\r\n{1} hours\r\n{2} minutes", days, hours, minutes);
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                
                // Runs the program again
                Console.WriteLine("\r\nWould you like to run this program again? (Yes/No)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;
            }
        }
    }
}
