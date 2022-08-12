using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_CONCEPTS
{
    public static class ShamsiDate
    {
        static ShamsiDate()
        {

        }

        public enum Days
        {
            شنبه,
            یکشنبه,
            دوشنبه,
            سه_شنبه,
            چهارشنبه,
            پنجشنبه,
            جمعه
        }

        public static string GetPersianDate()
        {
            var persianCalendar =
                new System.Globalization.PersianCalendar();

            int day =
                persianCalendar.GetDayOfMonth(time: System.DateTime.Now);

            int month =
                persianCalendar.GetMonth(time: System.DateTime.Now);

            int year =
                persianCalendar.GetYear(time: System.DateTime.Now);

            string persianDate =
                $"{year}/{month}/{day}";

            return persianDate;
        }

       public static Days GetDayName()
        {
            var persianCalendar =
               new System.Globalization.PersianCalendar();

            Days days= Days.جمعه;

            DayOfWeek dayOfWeek =
                persianCalendar.GetDayOfWeek(time: DateTime.Now);

            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                    {
                        days = Days.شنبه;
                        break;
                    }
                case DayOfWeek.Sunday:
                    {
                        days = Days.یکشنبه;
                        break;
                    }
                case DayOfWeek.Monday:
                    {
                        days = Days.دوشنبه;
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        days = Days.سه_شنبه;
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        days = Days.چهارشنبه;
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        days = Days.پنجشنبه;
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        days = Days.جمعه;
                        break;
                    }
            }

            return days;
        }
    }
}
