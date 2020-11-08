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
            //Addition of hotel with ratings into records
            HotelReservation.AddRatingsAndHotel();
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