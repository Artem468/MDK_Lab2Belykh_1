using System;
using System.Runtime.InteropServices.JavaScript;
using System.Windows;

namespace MDK_Lab1Belykh_1.Model
{
    public class Date : ITriad
    {
        public int Year {get; set; } 
        public int Month {get; set; } 
        public int Day {get; set; } 

        public Date()
        {
            Year = 2000;
            Month = 01;
            Day = 01;
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(string date)
        {
            DateOnly dateObj = DateOnly.Parse(date);
            Year = dateObj.Year;
            Month = dateObj.Month;
            Day = dateObj.Day;
        }
        
        public string Print()
        {
            return $"{Day}.{Month}.{Year}";
        }
        
        public void AddOne()
        {
            DateOnly date = new DateOnly(Year, Month, Day).AddDays(1);
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }
        
        public void AddDays(int dayToAdd)
        {
            DateOnly date = new DateOnly(Year, Month, Day).AddDays(dayToAdd);
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }
        
        public void SubDays(int dayToSub)
        {
            DateOnly date = new DateOnly(Year, Month, Day).AddDays(-dayToSub);
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }

        public bool IsLeapYear()
        {
            return DateTime.IsLeapYear(Year);
        } 
        
        public bool IsMore(Date date)
        {
            DateTime selfDate = new DateTime(Year, Month, Day);
            DateTime otherDate = new DateTime(date.Year, date.Month, date.Day);
            return selfDate > otherDate;
        }

        public bool IsLess(Date date)
        {
            DateTime selfDate = new DateTime(Year, Month, Day);
            DateTime otherDate = new DateTime(date.Year, date.Month, date.Day);
            return selfDate < otherDate;
        }

        public bool IsEqual(Date date)
        {
            DateTime selfDate = new DateTime(Year, Month, Day);
            DateTime otherDate = new DateTime(date.Year, date.Month, date.Day);
            return selfDate == otherDate;
        }

        public double DiffBetweenDays(Date date)
        {
            DateTime selfDate = new DateTime(Year, Month, Day);
            DateTime otherDate = new DateTime(date.Year, date.Month, date.Day);
            return double.Round((selfDate - otherDate).TotalDays);
        }
        
    }
}