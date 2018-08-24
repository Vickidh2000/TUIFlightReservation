using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightReservation.Presentation.Models
{
    public class AnalyticsService : IAnalyticsService
    {
        public string code
        {
            get { return "Tracking You !"; }
        }

     }
}