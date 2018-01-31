using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? LastUpdated { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime DateEntered { get; set; }

        public Client Client { get; set; }
        public ICollection<Task> Tasks { get; set; }

        public Project()
        {
            DateEntered = DateTime.Now;
        }
    }

    

    public enum Status 
    {
        Active, Complete
    }
}
