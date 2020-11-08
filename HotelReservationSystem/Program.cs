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
            HotelReservation.AddHotel("Lakewood", 110);
            HotelReservation.AddHotel("Bridgewood", 150);
            HotelReservation.AddHotel("Ridgewood", 220);
            //UC 2
            HotelReservation.FindCheapestHotel();
            Console.ReadLine();
        }
    }
}