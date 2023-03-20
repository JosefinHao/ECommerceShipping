using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceShipping.Model
{
    public static class Holidays
    {
        private static readonly Dictionary<string, List<DateTime>> holidays = new Dictionary<string, List<DateTime>>
        {
            ["US"] = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 1, 1), // New Year's Day
                new DateTime(DateTime.Now.Year, 7, 4), // Independence Day
                new DateTime(DateTime.Now.Year, 11, 11), // Veterans Day
                new DateTime(DateTime.Now.Year, 12, 25), // Christmas Day
            },
            ["China"] = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 1, 1), // New Year's Day
                new DateTime(DateTime.Now.Year, 5, 1), // Labour Day
                new DateTime(DateTime.Now.Year, 10, 1), // National Day
            },
            ["Sweden"] = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 1, 1), // New Year's Day
                new DateTime(DateTime.Now.Year, 6, 6), // National Day
                new DateTime(DateTime.Now.Year, 12, 24), // Christmas Eve
                new DateTime(DateTime.Now.Year, 12, 25), // Christmas Day
                new DateTime(DateTime.Now.Year, 12, 26), // Boxing Day
            }
        };

        public static bool IsHoliday(DateTime date, string manufacturer)
        {
            if (manufacturer == null || !holidays.ContainsKey(manufacturer))
            {
                return false;
            }
            else
            {
                return holidays[manufacturer].Contains(date);
            }
        }
    }


}
