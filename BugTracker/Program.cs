using System;
using BugTracker.DataAccess;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BugTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            RegisterServices();
            BuildServiceProvider(out LoginForm form);
            InitializeProjectDb();
            InitializeUsersDb();
            InitializeIssuesDb();
            Application.Run(form);
        }
        public static void InitializeIssuesDb()
        {
            var context = GetService<TrackerContext>();
            try
            {   
                for (int i = 0; i<10; i++)
                {
                    context.Issues.Add(new Issue()
                    {
                        Summary = "Issue " + i,
                        Description = "Feature " + i + " is broken",
                        Priority = Issue.PriorityLevel.Low,
                        Status = Issue.IssueStatus.Open,
                        UserId = 1,
                        ProjectId = 1
                    });
                    context.SaveChanges();
                }
                
            }
            catch (Exception)
            {
                return;
            }
        }
        public static void InitializeUsersDb()
        {
            var context = GetService<TrackerContext>();
            try
            {
                context.Users.Add(new User() { UserName = "Admin", Password = "admin", Email = "admin@gmail.com", UserRole = User.Role.Admin, ProjectId = 1 });
                context.SaveChanges();
            }
            catch (Exception)
            {
                return;
            }
        }
        public static void InitializeProjectDb()
        {
            var context = GetService<TrackerContext>();
            try
            {
                context.Projects.Add(new Project() { ProjectName = "One", StartDate = DateTime.Now, EndDate = DateTime.Now});
                context.SaveChanges();
            }
            catch (Exception)
            {
                return;
            }
        }
        private static IServiceCollection Services { get; set; } = new ServiceCollection();
        private static ServiceProvider ServiceProvider { get; set; }
        public static void RegisterServices()
        {
            Services.AddDbContext<TrackerContext>();
            Services.AddTransient<LoginForm>();
            Services.AddTransient<MainForm>();
            Services.AddTransient<RegistrationForm>();

            Services.AddSingleton<IUserRepository, UserRepository>(); 
            Services.AddSingleton<IProjectRepository, ProjectRepository>(); 
            Services.AddSingleton<IIssueRepository, IssueRepository>(); 
            //services.AddSingleton<IExportService, ExportService>();
        }

        public static void BuildServiceProvider(out LoginForm form)
        {
            ServiceProvider = Services.BuildServiceProvider();
            form = ServiceProvider.GetRequiredService<LoginForm>();
        }
        public static T GetService<T>()
        {
            return (T)ServiceProvider.GetRequiredService<T>();
        }
    }
}