using System;
using Bank_University;



namespace Bank_Logic
{
    // Class for keeping dates
    public class Date
    {
        // Private variables for class properties
        private int _day;
        private int _month;
        private int _year;


        public int Day
        {
            get => _day;
            // If the number of day less than 0 or more than amount of days in month program will
            //   change current month number and fix day number
            set
            {
                _day = value;
                FixDate();
            }
        }

        public int Month
        {
            get => _month;
            set
            {
                _month = value;
                FixDate();
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value <= 0)
                    throw new Exception("Year can't be < 0.");

                _year = value;
            }
        }



        // Constructors with start data
        public Date(int day, int month, int year)
        {
            SetDate(day, month, year);
        }

        public Date(Date date)
        {
            SetDate(date.Day, date.Month, date.Year);
        }



        // Private recursive function for fixing date info
        private void FixDate()
        {
            // If some data is incorrect, function will be called again
            bool incorrectDate = false;

            // Checking correct amount of days in current month
            // 31 days
            if (
                _month == 1 |
                _month == 3 |
                _month == 5 |
                _month == 7 |
                _month == 8 |
                _month == 10 |
                _month == 12)
            {
                if (_day > 31)
                {
                    _month += 1;
                    _day -= 31;
                    incorrectDate = true;
                }
                else if (_day <= 0)
                {
                    _month -= 1;
                    _day += 31;
                    incorrectDate = true;
                }
            }

            // 30 days
            else if (
                _month == 4 |
                _month == 6 |
                _month == 6 |
                _month == 9 |
                _month == 11)
            {
                if (_day > 30)
                {
                    _month += 1;
                    _day -= 30;
                    incorrectDate = true;
                }
                else if (_day <= 0)
                {
                    _month -= 1;
                    _day += 30;
                    incorrectDate = true;
                }
            }

            // 28-29 days
            else if (_month == 2)
            {
                // In leap days there are 1 extra day
                int extraDay = _year % 4 == 0 ? 1 : 0;
                if (_day > 28 + extraDay)
                {
                    _month += 1;
                    _day -= 28 + extraDay;
                    incorrectDate = true;
                }
                else if (_day <= 0)
                {
                    _month -= 1;
                    _day += 28 + extraDay;
                    incorrectDate = true;
                }
            }

            // Current month is not in range 1..12
            if (_month > 12)
            {
                _year += _month / 12;
                _month %= 12;
            }
            else if (_month <= 0)
            {
                _year += (-1 + _month / 12);
                _month = (_month % 12 + 12) % 12;
            }

            // Recalling FixDate() function
            if (incorrectDate)
                FixDate();
        }



        // Setting date function
        public void SetDate(int day, int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;
            FixDate();
        }

        public void SetDate(Date date)
        {
            _year = date.Year;
            _month = date.Month;
            _day = date.Day;
            FixDate();
        }



        // Overriding ToString() function. Returns "dd.mm.yyyy"
        public override string ToString()
        {
            return Day.ToString("D2")
                   + "." + Month.ToString("D2")
                   + '.' + Year.ToString("D4");
        }



        // Overriding Equals(...) method
        public override bool Equals(object obj)
        {
            try
            {
                Date date = (Date)obj;
                return Day == date.Day
                       && Month == date.Month
                       && Year == date.Year;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-----Static--class--members---------------------------------



        // Amount of seconds in program day (boosting process). As default sets below
        private static int _secondsPerDay = 1;
        public static Date CurrentDate;
        private static DateUpdateThread CurrentDateThread;

        // Amount of real seconds program needs to switch date on 1 day
        public static int SecondsPerDay
        {
            get => _secondsPerDay;
            set
            {
                if (value <= 0)
                    throw new Exception("The amount of seconds per day must bew > 0.");

                _secondsPerDay = value;
            }
        }



        // Extra Thread class for updating program data every second
        private class DateUpdateThread : CustomThread
        {
            private int _secondsPassed;

            private void UpdateDate()
            {
                if (++_secondsPassed >= SecondsPerDay)
                {
                    CurrentDate.Day++;
                    _secondsPassed = 0;

                    Bank.UpdateAllDeposits();
                }
            }

            public override void Run()
            {
                while (true)
                {
                    UpdateDate();
                    Sleep(1000);
                }
            }
        }



        // Static constructor. Starts CurrentTime Thread on first Date() class usage
        static Date()
        {
            int currentDay = 1;
            int currentMonth = 1;
            int currentYear = 1;

            CurrentDate = new Date(currentDay, currentMonth, currentYear);

            CurrentDateThread = new DateUpdateThread();
            CurrentDateThread.Start();
        }



        // Stops CurrentDate thread
        static public void StopCurrentDate() => CurrentDateThread.Stop();



        // True if range between two dates has extra day
        public static bool RangeContainsExtraDay(Date date1, Date date2)
        {
            date1 = new Date(date1);
            date2 = new Date(date2);

            date1.Year -= 1;
            date2.Year -= 1;
            int yearLower = date1 - date2;

            date1.Year += 1;
            date2.Year += 1;
            int currentYear = date1 - date2;

            date1.Year += 1;
            date2.Year += 1;
            int yearHigher = date1 - date2;

            return yearLower != currentYear && yearHigher != currentYear;
        }



        // Getting amount of days between 2 dates by operator "-"
        public static int operator -(Date higherDate, Date lowerDate)
        {
            // Difference between dates is found wia binary search
            if (higherDate.Equals(lowerDate))
                return 0;

            int multiplier = 1;
            if (lowerDate > higherDate)
            {
                Date temporary = higherDate;
                higherDate = lowerDate;
                lowerDate = temporary;
                multiplier = -1;
            }

            int left = (higherDate.Year - lowerDate.Year - 1) * 365;
            int right = (higherDate.Year - lowerDate.Year + 1) * 366;
            int center = (left + right) / 2;

            while (left != center)
            {
                Date temporary = new Date(lowerDate);
                temporary.Day += center;

                if (temporary > higherDate)
                    right = center;
                else if (temporary < higherDate)
                    left = center;
                else
                    return center * multiplier;

                center = (left + right) / 2;
            }

            return (left == center ? left : right) * multiplier;
        }



        // Overloading >, <, >=, <= for simple testing (if-checking)
        public static bool operator >(Date date1, Date date2)
        {
            if (date1.Year > date2.Year)
                return true;
            if (date1.Year < date2.Year)
                return false;

            if (date1.Month > date2.Month)
                return true;
            if (date1.Month < date2.Month)
                return false;

            if (date1.Day > date2.Day)
                return true;
            return false;
        }

        public static bool operator <(Date date1, Date date2)
        {
            if (date1.Year < date2.Year)
                return true;
            if (date1.Year > date2.Year)
                return false;

            if (date1.Month < date2.Month)
                return true;
            if (date1.Month > date2.Month)
                return false;

            if (date1.Day < date2.Day)
                return true;
            return false;
        }

        public static bool operator >=(Date date1, Date date2)
        {
            return date1 > date2 || date1.Equals(date2);
        }

        public static bool operator <=(Date date1, Date date2)
        {
            return date1 < date2 || date1.Equals(date2);
        }
    }
}