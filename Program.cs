using Hospital_System.Data;
using Hospital_System.Models;

namespace Hospital_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //ApplicationDbContext db = new ApplicationDbContext();
            //var doctors = new List<Doctor>
            //{
            //new Doctor {Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
            //new Doctor {Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
            //new Doctor {Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
            // new Doctor { Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
            //new Doctor { Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" },
            //};
            //db.Doctors.AddRange(doctors);
            //db.SaveChanges();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
