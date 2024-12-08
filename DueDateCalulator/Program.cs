using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DueDateCalulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DateCalculator calculator = new DateCalculator();
                DateTime dueDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(30));
            }
			catch (NotWorkingHourExeption e)
			{
                Console.WriteLine(e.Message);
			}
        }
    }
}
