using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayingTheBlues.Models;

namespace PlayingTheBlues.Controllers
{
    [Route("api/blues")]
    public class BluesController : Controller
    {
        [HttpGet]
        public BluesChords GetChords([FromQuery] string tonic)
        {
            var chords = new BluesChords();
            chords.Tonic = tonic;

            return chords;
        }
    }
}
