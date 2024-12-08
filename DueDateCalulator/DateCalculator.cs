using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DueDateCalulator
{
    public class DateCalculator
    {
        public DateCalculator()
        {

        }
        public DateTime CalculateDueDate(DateTime submitTime, TimeSpan turnaroundTime)
        {
            if (submitTime.Hour < 9 || (submitTime.Hour>17 && submitTime.Minute > 0))
            {
                throw new NotWorkingHourExeption();
            }

            int allHours = ((int)turnaroundTime.TotalHours);
            int workdays = allHours / 8;
            int remainingHours = allHours % 8;

            if (remainingHours == 0)
            {
                return submitTime.AddDays(workdays);
            }

            DateTime dueDate = submitTime.AddDays(workdays).AddHours(remainingHours);

            if (dueDate.Hour >= 17 && dueDate.Minute > 0)
            {
                dueDate = dueDate.AddHours(16);
            }

            return dueDate;
        }
    }
}
