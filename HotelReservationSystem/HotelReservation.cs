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
        /// Calculates the rate for each hotel and stores in dictionary.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, OutputHotel> CalculateRateForEachHotel()
        {
            try
            {
                Console.WriteLine("Enter the check-in date(DDMMMYYYY):");
                DateTime checkinDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the check-out date(DDMMMYYYY):");
                DateTime checkoutDate = DateTime.Parse(Console.ReadLine());
                Dictionary<string, OutputHotel> rateRecords = new Dictionary<string, OutputHotel>();
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
                    //UC 6 Refactor
                    OutputHotel outputHotel = new OutputHotel(v.Key, v.Value.ratings, totalRate);
                    rateRecords.Add(v.Value.hotelName, outputHotel);
                }
                return rateRecords;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// UC 2,4 : Finds the cheapest hotel.
        /// </summary>
        public static void FindCheapestHotel()
        {
            var rateRecords = CalculateRateForEachHotel();
            //Finds the key-value pair where rate is minimum by sorting the dictionary values in ascending order
            var kvp = rateRecords.OrderBy(kvp => kvp.Value.totalRate).First();
            //Iterating the rateRecords dictionary to check how many hotels provide the minimum rate
            foreach (var v in rateRecords)
            {
                //Checks where the minimum rate matches and displays the HotelName and Rate
                if (v.Value.totalRate == kvp.Value.totalRate)
                    Console.WriteLine($"{v.Key},TotalRate:{v.Value.totalRate}");
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
        /// <summary>
        /// UC 6 : Finds the cheapest best rated hotel.
        /// </summary>
        public static void FindCheapestBestRatedHotel()
        {
            //Get the raterecords dictionary
            var rateRecords = CalculateRateForEachHotel();
            //Dictionary initialized to store details of hotels with cheapest rate
            Dictionary<string, OutputHotel> cheapestRateDict = new Dictionary<string, OutputHotel>();
            var kvp = rateRecords.OrderBy(kvp => kvp.Value.totalRate).First();
            foreach (var v in rateRecords)
            {
                if (v.Value.totalRate == kvp.Value.totalRate)
                    //Add all hotels with same minimum totalRate
                    cheapestRateDict.Add(v.Key, v.Value);
            }
            //Calculates the max rating among all hotels with same totalRate
            var maxRating = cheapestRateDict.Select(item => item.Value.ratings).Max();
            foreach (var v in cheapestRateDict)
            {
                //Checks how many hotels have the rating=maxRating and prints the details
                if (v.Value.ratings == maxRating)
                    Console.WriteLine($"{v.Key},Ratings:{v.Value.ratings},TotalRate:{v.Value.totalRate}");
            }
        }
        /// <summary>
        /// UC 7 : Finds the best rated hotel amongst all hotels and displays the HotelName and total estimated rate for dates entered.
        /// </summary>
        public static void FindBestRatedHotel()
        {
            var rateRecords = CalculateRateForEachHotel();
            int maxRating = rateRecords.Select(item => item.Value.ratings).Max();
            foreach (var v in rateRecords)
            {
                if (v.Value.ratings == maxRating)
                    Console.WriteLine($"{v.Key},TotalRate:{v.Value.totalRate}");
            }
        }
    }
}