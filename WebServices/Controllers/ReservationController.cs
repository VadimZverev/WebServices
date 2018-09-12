﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class ReservationController : ApiController
    {
        private ReservationRespository repo = ReservationRespository.Current;

        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }

        public Reservation GetReservation(int id)
        {
            return repo.Get(id);
        }

        public bool PutReservation(Reservation item)
        {
            return repo.Update(item);
        }

        public void DeleteREservation(int id)
        {
            repo.Remove(id);
        }
    }
}
