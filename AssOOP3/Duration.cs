using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP3
{
    public class Duration
    {
        //Part2 Q1
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        // Q3
        public Duration() { 
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public Duration(int hours, int minutes, int seconds) { 
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds) { 
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        private void Normalize() {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }

            if (Seconds < 0 || Minutes < 0 || Hours < 0)
                throw new ArgumentException("Negative duration is not allowed.");

        }
        //Q2
        public override string ToString()
        {
            string result = "";

            if (Hours > 0)
                result += $"Hours: {Hours}, ";

            if (Hours > 0 || Minutes > 0)
                result += $"Minutes :{Minutes}, ";

            result += $"Seconds :{Seconds}";

            return result;
        }

        public override bool Equals(object obj) { 
        if (obj == null || GetType() != obj.GetType()) 
                return false;

        Duration other = (Duration)obj;
            return Hours == other.Hours &&
                Minutes == other.Minutes &&
                Seconds == other.Seconds;
        }

        public override int GetHashCode() { 
        return HashCode.Combine(Hours, Minutes, Seconds);
        }

        //Q4
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration
                (
                a.Hours + b.Hours, 
                a.Minutes + b.Minutes,
                a.Seconds + b.Seconds
                );
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(
                d.TotalSeconds() + seconds
            );
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            int totalSeconds = d.TotalSeconds() - 60;
            if (totalSeconds < 0) totalSeconds = 0;
            return new Duration(totalSeconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int resultSeconds = d1.TotalSeconds() - d2.TotalSeconds();
            if (resultSeconds < 0)
                resultSeconds = 0;
            return new Duration(resultSeconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        public static implicit operator bool(Duration d)
        {
            return d.TotalSeconds() > 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            // We'll convert Duration to a DateTime today + duration
            return DateTime.Today
                   .AddHours(d.Hours)
                   .AddMinutes(d.Minutes)
                   .AddSeconds(d.Seconds);
        }

        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
    }
}
