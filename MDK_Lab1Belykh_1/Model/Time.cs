using System;

namespace MDK_Lab1Belykh_1.Model
{
    public class Time : ITriad
    {
        
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        
        public Time()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public Time(string time)
        {
            TimeOnly timeObj = TimeOnly.Parse(time);
            Hour = timeObj.Hour;
            Minute = timeObj.Minute;
            Second = timeObj.Second;
        }

        public Time(DateTime datetime)
        {
            Hour = datetime.Hour;
            Minute = datetime.Minute;
            Second = datetime.Second;
        }
        
        public string Print()
        {
            return $"{Hour}:{Minute}:{Second}";
        }
        
        public void AddOne()
        {
            TimeOnly time = new TimeOnly(Hour, Minute, Second).Add(TimeSpan.FromSeconds(1));
            Hour = time.Hour;
            Minute = time.Minute;
            Second = time.Second;
        }
        
        public double TimeSub(Time obj)
        {
            TimeOnly time = new TimeOnly(Hour, Minute, Second);
            TimeOnly timeObj = new TimeOnly(obj.Hour, obj.Minute, obj.Second);
            return (time - timeObj).TotalSeconds;
        }

        public void AddSeconds(int seconds)
        {
            TimeOnly time = new TimeOnly(Hour, Minute, Second).Add(TimeSpan.FromSeconds(seconds));
            Hour = time.Hour;
            Minute = time.Minute;
            Second = time.Second;
        }

        public void SubSeconds(int seconds)
        {
            TimeOnly time = new TimeOnly(Hour, Minute, Second).Add(-TimeSpan.FromSeconds(seconds));
            Hour = time.Hour;
            Minute = time.Minute;
            Second = time.Second;
        }

        public bool IsMore(Time time)
        {
            return new TimeSpan(Hour, Minute, Second) > 
                   new TimeSpan(time.Hour, time.Minute, time.Second);
        }

        public bool IsLess(Time time)
        {
            return new TimeSpan(Hour, Minute, Second) <
                   new TimeSpan(time.Hour, time.Minute, time.Second);
        }

        public bool IsEqual(Time time)
        {
            return new TimeSpan(Hour, Minute, Second) == 
                   new TimeSpan(time.Hour, time.Minute, time.Second);
        }
        
        public double ToSeconds()
        {
            TimeSpan time = new TimeSpan(Hour, Minute, Second);
            return double.Round(time.TotalSeconds);
        }

        public double ToMinutes()
        {
            TimeSpan time = new TimeSpan(Hour, Minute, Second);
            return double.Round(time.TotalMinutes);
        }
        
    }
}