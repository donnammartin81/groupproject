using System;

namespace groupproject.Models
{
    public class Resident{
        public int Id {get;set;}
        public string  firstName {get;set;}

        public string lastName {get;set;}
        public string email {get;set;}
        public string phone {get;set;}
        public string address {get;set;}
        public DateTime TimeStamp {get;set;} = DateTime.Now;



    }

}