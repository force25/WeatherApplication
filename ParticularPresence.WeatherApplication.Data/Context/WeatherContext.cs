using ParticularPresence.WeatherApplication.Models;
using System.Data.Entity;

namespace ParticularPresence.WeatherApplication.Data
{
    public class WeatherContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
