using System;


namespace ZeroHunger.Models
{
    public class ResturentRequests
    {
        public string ResturentName { get; set; }
        public string ResturentLocation { get; set; }
        public DateTime PreserveDate { get; set; }

        [Age]          
        public int age { get; set; }

        public string Assigned { get; set; }
        public string Status { get; set; }
    }
}
