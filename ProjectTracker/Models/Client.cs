using System;
using System.Collections.Generic;

namespace ProjectTracker.Models
{
   
    public class Client
    {
        public int ClientID { get; set; }
        
        public string ClientName { get; set; }

        public ICollection<Project> Projects { get; set; }
    }

}
