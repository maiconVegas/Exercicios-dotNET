using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.booking_up_for_beauty
{
    internal static class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription)
        {
            //return DateTime.TryParseExact(appointmentDateDescription, "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            return DateTime.Now.AddDays(1);
        }

        public static bool HasPassed(DateTime appointmentDate)
        {
            throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
        }

        public static string Description(DateTime appointmentDate)
        {
            throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
        }

        public static DateTime AnniversaryDate()
        {
            throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
        }
    }
}
