// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program:\n");
            //UC 3 Refactor
            HotelReservation.AddHotel("Lakewood", 110, 90);
            HotelReservation.AddHotel("Bridgewood", 150, 50);
            HotelReservation.AddHotel("Ridgewood", 220, 150);
            //UC 5
            HotelReservation.AddRatings("Bridgewood", 4);
            HotelReservation.AddRatings("Lakewood", 3);
            HotelReservation.AddRatings("Ridgewood", 5);
            //UC 2
            //HotelReservation.FindCheapestHotel();
            //UC 6
            //HotelReservation.FindCheapestBestRatedHotel();
            //UC 7
            HotelReservation.FindBestRatedHotel();
            Console.ReadLine();
        }
    }
}