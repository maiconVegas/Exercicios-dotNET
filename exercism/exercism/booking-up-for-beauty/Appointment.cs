﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.booking_up_for_beauty
{
    internal static class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

        public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

        public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
        
        public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString()}.";

        public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);
    }
}
