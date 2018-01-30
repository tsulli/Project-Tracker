﻿using System;
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
                new Project{ClientID=1,ProjectName="Phase Two",Status=Status.Active,EnteredBy="tsulli",DateEntered=DateTime.Parse("2015-05-09 13:45:00"),LastUpdated=System.DateTime.Now},
                new Project{ClientID=3,ProjectName="GLaDOS",Status=Status.Active,EnteredBy="tsulli",DateEntered=DateTime.Parse("1998-10-23 08:25:00"),LastUpdated=System.DateTime.Now},
                new Project{ClientID=4,ProjectName="Da Vinci",Status=Status.Active,EnteredBy="tsulli",DateEntered=DateTime.Parse("1995-07-01 10:15:00"),LastUpdated=System.DateTime.Now}
            };
                foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

            var tasks = new Task[]
            {
                new Task{ProjectID=2,RequestedBy="Theresa",CompletedBy="Theresa",Component=Component.Programming,Description="The cake is a lie.",Hours=8,EnteredBy="tsulli",DateEntered=DateTime.Parse("2018-01-23")}
            };
            foreach (Task t in tasks)
            {
                context.Tasks.Add(t);
            }
            context.SaveChanges();
        }
    }
}
