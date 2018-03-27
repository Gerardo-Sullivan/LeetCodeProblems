using System.Collections.Generic;

namespace LeetCodeProblems.MyCalenderThreeProblem
{
    /// <summary>
    /// Stores events
    /// An event is stored as a booking, represented by two time intervals [start, end]
    /// </summary>
    /// <remarks>the range of real numbers x that are represent in a booking are, "start<= x < end"</remarks>
    public class MyCalenderThree
    {
        private List<int[]> _bookings;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MyCalenderThree()
        {
            _bookings = new List<int[]>();
        }

        /// <summary>
        /// Returns a K-bookings i.e. number of overlapping bookings
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        /// <remarks>Returns 1 when there are no overlapping bookings with the one created</remarks>
        public int Book(int start, int end)
        {
            int count = 0;
            int[] newbooking = new int[] { start, end };


            foreach (var booking in _bookings)
            {
                if (booking[1] > start && booking[1] < end)
                {
                    count++;
                }
                else if (booking[0] < end && booking[0] >= start)
                {
                    count++;
                }
            }
            AddBooking(newbooking[0], newbooking[1]);
            return ++count;
        }

        /// <summary>
        /// Add booking to list of bookings
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void AddBooking(int start, int end)
        {
            //int k = 1; //dynamic programming
            _bookings.Add(new int[] { start, end });
        }
    }
}
