using System;
using ProjectTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectTracker.Data {
    public class ProjectTrackerContext : DbContext {
        public ProjectTrackerContext (DbContextOptions<ProjectTrackerContext> options) : base(options) {}

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
