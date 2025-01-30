using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOTuples.phone_number_analysis
{
    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            var num = phoneNumber.Split('-');
            return (num[0].Equals("212"), num[1].Equals("555"), num[2]);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) =>
            phoneNumberInfo.IsFake;
    }
}
