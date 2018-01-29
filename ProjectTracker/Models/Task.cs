using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Models {

    public class Task
    {
       public int TaskID { get; set; }
       public int ProjectID { get; set; }
       
       public string RequestedBy { get; set; }

       public string CompletedBy { get; set; }

       public Component Component { get; set; }

       public string Description { get; set; }

       public double Hours { get; set; }

       public string EnteredBy { get; set; }

       public DateTime DateEntered { get; set; }
       public DateTime LastUpdated { get; set; }
    }

    public enum Component
    {
        Website, Programming, Design, Photography, Video, Writing, Other
    }

}

