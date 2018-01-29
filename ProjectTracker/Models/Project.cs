using System;
using System.Collections.Generic;

namespace ProjectTracker.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public int ClientID { get; set; }

        public string ProjectName { get; set; }

        public Status Status { get; set; }

        public string EnteredBy { get; set; }

        public string Notes { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime DateEntered { get; set; }

        public Client Client { get; set; }
        public ICollection<Task> Tasks { get; set; } 
    }

    public enum Status 
    {
        Active, Complete
    }
}
