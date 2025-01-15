using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Duration
    {
        public int Hour {  get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public override string ToString()
        {
            return $"Hour = {Hour} Minute = {Minute} Seconds = {Second}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hour == other.Hour && Minute == other.Minute && Second == other.Second;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minute, Second);
        }
        private void Normalize()
        {
            if (Second >= 60)
            {
                Minute += Second / 60;
                Second %= 60;
            }

            if (Minute >= 60)
            {
                Hour += Minute / 60;
                Minute %= 60;
            }
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hour = hours;
            Minute = minutes;
            Second = seconds;
            Normalize();
        }

        public int ToTotalSeconds()
        {
            return (Hour * 3600) + (Minute * 60) + Second;
        }

        public Duration(int totalSeconds)
        {
            Hour = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minute = totalSeconds / 60;
            Second = totalSeconds % 60;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hour + d2.Hour, d1.Minute + d2.Minute, d1.Second + d2.Second);
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.ToTotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration(d1.ToTotalSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() - d2.ToTotalSeconds());
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hour+1, d.Minute+1, d.Second-1);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hour-1, d.Minute-1, d.Second-1);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.ToTotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.ToTotalSeconds() <= 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(2003, 10, 15, d.Hour, d.Minute, d.Second);
        }
    }
}
