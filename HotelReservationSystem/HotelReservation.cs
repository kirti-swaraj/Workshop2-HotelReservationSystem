// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotelReservation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class HotelReservation
    {
        public static Dictionary<string, Hotel> hotelRecords = new Dictionary<string, Hotel>();

        /// <summary>
        /// UC 1 : Adds the hotel into the record.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="ratePerDay">The rate per day.</param>
        public static void AddHotel(string hotelName, int weekdayRate, int weekendRate)
        {
            //UC 3 Refactor
            if (!hotelRecords.ContainsKey(hotelName))
            {
                Hotel newHotel = new Hotel(hotelName, weekdayRate, weekendRate);
                hotelRecords.Add(hotelName, newHotel);
            }
            else
            {
                Console.WriteLine($"Hotel {hotelName} already exists in the records\n");
            }
        }
        /// <summary>
        /// UC 2,4 : Finds the cheapest hotel for the date range.
        /// </summary>
        public static void FindCheapestHotel()
        {
            try
            {
                Console.WriteLine("Enter the check-in date(DDMMMYYYY):");
                DateTime checkinDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the check-out date(DDMMMYYYY):");
                DateTime checkoutDate = DateTime.Parse(Console.ReadLine());
                Dictionary<string, int> rateRecords = new Dictionary<string, int>();
                //UC 4 Refactor
                foreach (var v in hotelRecords)
                {
                    int totalRate = 0;
                    DateTime tempDate = checkinDate;
                    while (tempDate <= checkoutDate)
                    {
                        //Checking if the day is weekend
                        if (tempDate.DayOfWeek == DayOfWeek.Saturday || tempDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            totalRate += v.Value.weekendRate;
                        }
                        else
                        {
                            totalRate += v.Value.weekdayRate;
                        }
                        //Incrementing the current tempdate to next day
                        tempDate = tempDate.AddDays(1);
                    }
                    rateRecords.Add(v.Value.hotelName, totalRate);
                }
                //Finds the key-value pair where rate is minimum by sorting the dictionary values in ascending order
                var kvp = rateRecords.OrderBy(kvp => kvp.Value).First();
                //Iterating the rateRecords dictionary to check how many hotels provide the minimum rate
                foreach (var v in rateRecords)
                {
                    if (v.Value == kvp.Value)
                        Console.WriteLine($"{v.Key},TotalRate:{v.Value}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// UC 5 : Adds the ratings to the specified hotel.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="ratings">The ratings.</param>
        public static void AddRatings(string hotelName, int ratings)
        {
            foreach (var v in hotelRecords)
            {
                if (v.Key == hotelName)
                {
                    v.Value.ratings = ratings;
                    break;
                }
            }
        }
    }
}