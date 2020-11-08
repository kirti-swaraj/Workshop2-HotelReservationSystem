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
            HotelReservation.AddRatingsAndHotel();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter:\n1.To find cheapest hotels\n2.To find best rated hotel\n3.To find cheapest best rated hotel\n4.To exit\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        //UC 2
                        HotelReservation.FindCheapestHotel();
                        break;
                    case 2:
                        //UC 7
                        HotelReservation.FindBestRatedHotel();
                        break;
                    case 3:
                        //UC 6
                        HotelReservation.FindCheapestBestRatedHotel();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
 
