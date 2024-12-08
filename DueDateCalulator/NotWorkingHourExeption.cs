using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DueDateCalulator
{
    public class NotWorkingHourExeption : Exception
    {
        public NotWorkingHourExeption():
            base("The submit time on the task is not in the working hours(beetwen 9am, 5pm)")
        {
            
        }
        public NotWorkingHourExeption(string message):base(message) 
        {
        }
    }
}
