using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIHelloWorld.Models
{
    public class HelloWorldPeople
    {
        //creating data model class as example -- this could come from entity framework model
        public int WorldId { get; set; }
        public string WorldGreeting { get; set; }
        public string WorldPerson { get; set; }

    }
}