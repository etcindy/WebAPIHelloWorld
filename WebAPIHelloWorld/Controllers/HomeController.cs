using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIHelloWorld.Models;

namespace WebAPIHelloWorld.Controllers
{
    public class HomeController : ApiController
    {

        //generic list of data
        List<HelloWorldPeople> HelloWrld = new List<HelloWorldPeople>()
        {
            // this would be coming from database
            new HelloWorldPeople { WorldId=1, WorldGreeting = "Hello Earth", WorldPerson = "John"},
            new HelloWorldPeople { WorldId=2, WorldGreeting = "Hello Venus", WorldPerson = "Megan"},
            new HelloWorldPeople { WorldId=3, WorldGreeting = "Hello Saturn", WorldPerson = "Matt"}
        };


        [HttpGet]  // http://localhost:53867/api/Home will return json or xml can determine
        public IEnumerable<HelloWorldPeople> GetWrldDetails()
        {
            return HelloWrld;
        }

        
    }
}
