using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class GradeformModel
    {
        // this line builds getters and setters for us
        public string From { get; set; } // define the type and the size of the variable, find the smallest memory we can fit this in
        public string Subject { get; set; }
        public string Message { get; set; }
        
        
        // this is a setter
        //public void setFrom(string input)
        //{
        //    this.From = input;
        //}

        ////getter
        //public string getFrom()
        //{
        //    return this.From;
        //}    
    }
}
