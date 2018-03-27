using System;

namespace LeetCodeProblems.MyCalenderThreeProblem
{
    /// <summary>
    /// <a href="https://leetcode.com/problems/my-calendar-iii/description/">LeetCode link</a>
    /// </summary>
    public class Solution
    {
        public static void Run()
        {
            MyCalenderThree calender = new MyCalenderThree();
            PrintKBooking(calender.Book(10, 20));
            PrintKBooking(calender.Book(50, 60));
            PrintKBooking(calender.Book(10, 40));
            PrintKBooking(calender.Book(5, 15));
            PrintKBooking(calender.Book(5, 10));
            PrintKBooking(calender.Book(25, 55));
        }

        private static void PrintKBooking(int kBooking)
        {
            Console.WriteLine($"Num of kBookings: {kBooking}");
        }
    }
}
