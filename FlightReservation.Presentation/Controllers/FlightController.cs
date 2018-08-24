using FlightReservartion.DAL;
using FlightReservation.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FlightReservation.Presentation.Controllers
{
    public class FlightController : Controller
    {

        private IFlightServices _flightService;

        

        public FlightController(IFlightServices flightService)
        {
            this._flightService = flightService;
            
        }

        // GET: Flight
        public ActionResult Index()
        {
            var Model = _flightService.GetFlight();

            return View(Model);
        }

        // GET: Flight/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Flight/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flight/Create
        [HttpPost]
        public ActionResult Create(Flight flight)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    flight.Flight_id = Guid.NewGuid().ToString();

                    var DepartureCoord =_flightService.GetCoordinate(flight.Departure);

                    var DestinationCoord = _flightService.GetCoordinate(flight.Destination);

                    var Distance = DistanceCalculService.CalculDistance(DepartureCoord[0],                  
                    DepartureCoord[1], DestinationCoord[0], DestinationCoord[1]);
                          

                    flight.Distance = (decimal?)Distance / 1000;


                    flight.FuelConsumption = (decimal?)FuelCalculService.FuelCalculation(Distance / 1000);


                    _flightService.CreateFlight(flight);

                    //ViewBag.Departure = _flightService.GetAllAirportNames();

                    return RedirectToAction("Index");
                }
                return View(flight);
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var flight =  _flightService.GetFlightById(id);
           
            if (flight == null)
            {
                return HttpNotFound();
            }
            
            return View(flight);
        }

       

        // POST: Flight/Edit/5
        [HttpPost]
        public ActionResult Edit(Flight flight)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _flightService.UpdateFlight(flight);
                    
                    return RedirectToAction("Index");
                }
                return View(flight);
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/Delete/5
        public ActionResult Delete(string id)
        {
            var flight = _flightService.GetFlightById(id);

            if (flight == null)
            {
                return HttpNotFound();
            }
            
            return View(flight);
         
        }

        // POST: Flight/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, Flight flight)
        {
            try
            {
                

                flight = _flightService.GetFlightById(id);

                if (flight == null)
                {
                    return HttpNotFound();
                }
                _flightService.RemoveFlight(flight);

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                var ex = e.Message;
                return View();
            }
        }
    }
}
