// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotelReservation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;
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
    }
}