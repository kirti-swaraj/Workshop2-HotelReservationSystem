// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutputHotel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UC 6 : Class to represent objects of output hotels after filtering to be presented at frontEnd
    /// </summary>
    public class OutputHotel
    {
        public string hotelName;
        public int ratings;
        public int totalRate;

        public OutputHotel(string hotelName, int ratings, int totalRate)
        {
            this.hotelName = hotelName;
            this.ratings = ratings;
            this.totalRate = totalRate;
        }
    }
}