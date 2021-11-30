using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int hoursWorked;
        private static int basePay;
        private static int overtimeHours;
        private static int overtimePay;
        private static int unitPay;
        private static int hourlyPayRate;
        private static int grosspay;
      

        public static int BASE_HOURS { get; private set; }
        public static int OVERTIME_RATE { get; private set; }

        private static void calculatesalaray()
        {
            if(hoursWorked > BASE_HOURS)
            {
                basePay = hourlyPayRate * BASE_HOURS;

                overtimeHours = hoursWorked - BASE_HOURS;

                overtimePay = overtimeHours * hourlyPayRate * OVERTIME_RATE;

                unitPay = 3* 5;

                grosspay = basePay + overtimePay + unitPay;



            }
        }
    }
}
