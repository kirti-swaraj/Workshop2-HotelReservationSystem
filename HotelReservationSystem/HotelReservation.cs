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
        public static void AddHotel(string hotelName, int ratePerDay)
        {
            if (!hotelRecords.ContainsKey(hotelName))
            {
                Hotel newHotel = new Hotel(hotelName, ratePerDay);
                hotelRecords.Add(hotelName, newHotel);
            }
            else
            {
                Console.WriteLine($"Hotel {hotelName} already exists in the records\n");
            }
        }
        /// <summary>
        /// UC 2 : Finds the cheapest hotel for the date range.
        /// </summary>
        public static void FindCheapestHotel()
        {
            try
            {
                Console.WriteLine("Enter the check-in date(DDMMMYYYY):");
                DateTime checkinDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the check-out date(DDMMMYYYY):");
                DateTime checkoutDate = DateTime.Parse(Console.ReadLine());
                int noOfDays = (checkoutDate - checkinDate).Days + 1;
                Dictionary<string, int> rateRecords = new Dictionary<string, int>();
                foreach (var v in hotelRecords)
                {
                    int rate = v.Value.ratePerDay * noOfDays;
                    rateRecords.Add(v.Value.hotelName, rate);
                }
                var kvp = rateRecords.OrderBy(kvp => kvp.Value).First();
                Console.WriteLine($"{kvp.Key},TotalRate:{kvp.Value}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}