// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotelReservationCustomException.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    /// <summary>
    /// Custom Exceptions
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class HotelReservationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DATE_FORMAT,
            INVALID_DATE_RANGE,
            INVALID_CUSTOMER_TYPE
        }

        public ExceptionType exceptionType;

        /// <summary>
        /// UC 10 : Adding custom exceptions for invalid entries
        /// Initializes a new instance of the <see cref="HotelReservationCustomException"/> class.
        /// </summary>
        /// <param name="exceptionType">Type of the exception.</param>
        /// <param name="message">The message.</param>
        public HotelReservationCustomException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}