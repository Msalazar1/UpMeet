using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpMeet.Models;
using UpMeet.Services;

namespace UpMeet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IDAL dal;
        public EventsController(IDAL dal)
        {
            this.dal = dal;
        }

        public IEnumerable<Events> GetAll()
        {
            return dal.GetAllEvents();
        }

    }
}
