
using System;

namespace UltimoDiadoMes
{
    class Program
    {
        static void Main(string[] args)
        {
            var ultimoDia = DateTime.Now.GetUltimoDiaMes();
            Console.WriteLine(ultimoDia);
        }

    }


    static class DateTimeExtensions
    {
        public static int GetUltimoDiaMes(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).Day;
        }
    }
}
