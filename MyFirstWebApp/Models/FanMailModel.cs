using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class FanMailModel
    {
        // this line builds getters and setters for us
        [Email Address]
        [MaxLength(25)]
        public string From { get; set; } // define the type and the size of the variable, find the smallest memory we can fit this in
        public string Subject { get; set; }
        public string Message { get; set; }


    }
}
