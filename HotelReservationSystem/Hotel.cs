// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hotel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hotel
    {
        public string hotelName;
        public int ratePerDay;

        public Hotel(string hotelName, int ratePerDay)
        {
            this.hotelName = hotelName;
            this.ratePerDay = ratePerDay;
        }
    }
}