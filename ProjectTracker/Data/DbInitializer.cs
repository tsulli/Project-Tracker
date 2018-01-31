using System;
using ProjectTracker.Models;
using System.Linq;

namespace ProjectTracker.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProjectTrackerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any projects
            if (context.Projects.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new Client[]
            {
                new Client{ClientName="E Corp."},
                new Client{ClientName="Stark Industries"},
                new Client{ClientName="Aperture Science"},
                new Client{ClientName="Ellingson Mineral Company"}
            };
            foreach (Client c in clients)
            {
                context.Clients.Add(c);
            }
            context.SaveChanges();

            var projects = new Project[]
            {
                new Project{ClientID=1,ProjectName="Phase Two",Status=Status.Active,EnteredBy="tsulli"},
                new Project{ClientID=3,ProjectName="GLaDOS",Status=Status.Active,EnteredBy="tsulli"},
                new Project{ClientID=4,ProjectName="Da Vinci",Status=Status.Active,EnteredBy="tsulli"}
            };
                foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

            var tasks = new Task[]
            {
                new Task{ProjectID=2,RequestedBy="Theresa",CompletedBy="Theresa",Component=Component.Programming,Description="The cake is a lie.",Hours=8,EnteredBy="tsulli"}
            };
            foreach (Task t in tasks)
            {
                context.Tasks.Add(t);
            }
            context.SaveChanges();
        }
    }
}
